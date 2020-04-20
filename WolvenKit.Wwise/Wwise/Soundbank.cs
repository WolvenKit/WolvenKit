using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WolvenKit.Wwise.Wwise
{

    public class Soundbank
    {
        public const int MODE_BUILD = 0;
        public const int MODE_BUILD_MUSIC = 1;
        public const int MODE_ADD_NEW_MUSIC = 2;
        public const int MODE_PLAYLIST_ID = 3;
        public const int MODE_EXPORT_PLAYLIST = 4;
        public const int MODE_REIMPORT_PLAYLIST = 5;
        public const int MODE_DEBUG = 6;

        public FileRead _file;
        public string _fileName;
        public SBHeader _header = null;
        public SBDataIndex _dataIndex = null;
        public SBData _data = null;
        public SBObjects _objects = null;
        public SBSoundTypeID _stid = null;
        public SBManager _stmg = null;
        public SBEnvironments _envs = null;
        public List<WEM> _to_add = new List<WEM>();
        public bool _isInit;

        
        public Soundbank(string fileName)
        {
            try
            {
                _fileName = fileName;
                _file = new FileRead(fileName);

                _header = null;
                _dataIndex = null;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not open soundbank, program is down");
                Environment.Exit(0);
            }

        }

        ~Soundbank()
        {
            if (_file != null)
            {
                _file.closeFile();
            }
        }

        
        public void readFile()
        {
            _header = new SBHeader(_file);
            _isInit = (_fileName == "Init.bnk");

            if (!_isInit)
            {
                _dataIndex = new SBDataIndex(_file);
                _data = new SBData(_file);

                if (_data._isSet && _dataIndex._isSet)
                {
                    _data.read_data(_file, _dataIndex);
                }
                else
                {
                    Console.WriteLine("SBData or SBDataIndex is not loaded");
                    Environment.Exit(0);
                }
            }
            else
            {
                // manager
                _stmg = new SBManager(_file);
            }

            _objects = new SBObjects(_file);
            if (!_isInit)
            {
                _stid = new SBSoundTypeID(_file);
            }
            else
            {
                _envs = new SBEnvironments(_file);
            }

            _file.closeFile();
        }

        
        public void debugSound()
        {
            Console.WriteLine("--- Header Start ---");
            Console.WriteLine("Head : " + _header._head);
            Console.WriteLine("Length : " + _header._length);
            Console.WriteLine("Version : " + _header._version);
            Console.WriteLine("ID : " + _header._id);
            Console.WriteLine("UNK Field32 1 : " + _header._unk_field32_1);
            Console.WriteLine("UNK Field32 2 : " + _header._unk_field32_2);

            if (_header._unk_data != "")
            {
                Console.WriteLine("UNK Data Length : " + _header._unk_data.Length);
            }
            Console.WriteLine("--- Header ---");
            Console.WriteLine("");

            if (!_isInit)
            {
                if (_dataIndex != null && _dataIndex._isSet)
                {
                    Console.WriteLine("--- Data Index Start ---");
                    Console.WriteLine("Head : " + _dataIndex._head);
                    Console.WriteLine("Length : " + _dataIndex._length);

                    int i = 1;
                    foreach (WEM w in _dataIndex._data_info)
                    {
                        Console.WriteLine("Data info " + i + " : (ID: " + w._id + "), (Offset: " + w._offset + "), (Size: " + w._size + ")");
                        i++;
                    }
                    Console.WriteLine("--- Data Index End ---");
                    Console.WriteLine("");
                }

                if (_data != null && _data._isSet)
                {
                    Console.WriteLine("--- Data Start ---");
                    Console.WriteLine("Head : " + _data._head);
                    Console.WriteLine("Length (Non padded) : " + _dataIndex.get_total_size());
                    Console.WriteLine("Length : " + _data._length);
                    Console.WriteLine("Offset : " + _data._offset);
                    Console.WriteLine("--- Data End ---");
                    Console.WriteLine("");
                }
            }
            else
            {
                if (_stmg != null && _stmg._isSet)
                {
                    Console.WriteLine("--- Manager Start ---");
                    Console.WriteLine("Head : " + _stmg._head);
                    Console.WriteLine("Length : " + _stmg._length);
                    Console.WriteLine("Volume : " + _stmg._volume);
                    Console.WriteLine("Max voice instances : " + _stmg._max_voice_instances);
                    Console.WriteLine("State groups : " + _stmg._state_groups_count);
                    Console.WriteLine("Switch groups : " + _stmg._switch_groups_count);
                    Console.WriteLine("Game parameters : " + _stmg._game_parameters_count);
                    Console.WriteLine("--- Manager End ---");
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("--- Objects Start ----");
            Console.WriteLine("Head : " + _objects._head);
            Console.WriteLine("Length : " + _objects._length);
            Console.WriteLine("Quantity : " + _objects._quantity);

            var objTypes = new Dictionary<byte, int>();
            foreach (SBObject obj in _objects._objects)
            {
                if (objTypes.ContainsKey(obj._type))
                {
                    objTypes[obj._type] += 1;
                }
                else
                {
                    objTypes.Add(obj._type, 1);
                }
            }

            foreach (KeyValuePair<byte, int> t in objTypes)
            {
                Console.WriteLine("Type " + t.Key + " : " + t.Value);
            }
            Console.WriteLine("--- Objects End ---");
            Console.WriteLine("");

            if (!_isInit)
            {
                if (_stid != null && _stid._isSet)
                {
                    Console.WriteLine("--- Sound type id Start ---");
                    Console.WriteLine("Head : " + _stid._head);
                    Console.WriteLine("Length : " + _stid._length);
                    Console.WriteLine("UNK Field32 1 : " + _stid._unk_field32_1);
                    Console.WriteLine("Quantity : " + _stid._quantity);
                    Console.WriteLine("Remaining size : " + _stid._remaining.Length);
                    Console.WriteLine("--- Sound type id End ---");
                    Console.WriteLine("");
                }
                else if (_envs != null && _envs._isSet)
                {
                    Console.WriteLine("--- Environments Start ---");
                    Console.WriteLine("Head : " + _envs._head);
                    Console.WriteLine("Length : " + _envs._length);
                    Console.WriteLine("Unk data length : " + _envs._unk_data.Length);
                    Console.WriteLine("--- Environments End ---");
                    Console.WriteLine("");
                }
            }
        }

        
        public void rebuild_data()
        {
            foreach (WEM w in _dataIndex._data_info)
            {
                foreach (WEM w1 in _to_add)
                {
                    if (w._id == w1._id)
                    {
                        w._size = w1._size;
                        w._data = w1._data;
                        break;
                    }
                }
            }
        }

        
        public void get_playlist_ids(uint wid)
        {
            if (wid < 1 || wid > 0xFFFFFFFF)
            {
                Console.WriteLine("Soundbank (get_playlist_ids) : Invalid music ID");
                return;
            }
            List<uint> trackids = new List<uint>();

            foreach (var obj in _objects._objects)
            {
                if (obj._type == SBObject.TYPE_MUSIC_TRACK)
                {
                    if (obj._obj_mto._id1 == wid)
                    {
                        trackids.Add(obj._id);
                    }
                }
            }
            if (trackids.Count == 0)
            {
                Console.WriteLine("Could not find ID : " + wid + " within soundbank");
                return;
            }
            List<uint> segids = new List<uint>();

            foreach (var obj in _objects._objects)
            {
                if (obj._type == SBObject.TYPE_MUSIC_SEGMENT)
                {
                    foreach (var id in trackids)
                    {
                        if (obj._obj_mso._child_ids.Contains(id))
                        {
                            segids.Add(obj._id);
                            break;
                        }
                    }
                }
            }
            if (segids.Count == 0)
            {
                Console.WriteLine(wid + " has no music segments");
                return;
            }

            List<uint> playlist_ids = new List<uint>();
            foreach (var obj in _objects._objects)
            {
                if (obj._type == SBObject.TYPE_MUSIC_PLAYLIST)
                {
                    foreach (var id in segids)
                    {
                        if (obj._obj_mpo._segment_ids.Contains(id))
                        {
                            playlist_ids.Add(obj._id);
                            break;
                        }
                    }
                }
            }
            if (playlist_ids.Count == 0)
            {
                Console.WriteLine(wid + " has no music playlists");
                return;
            }
            string s = string.Join(", ", playlist_ids.ToArray());

            Console.WriteLine("[*] Playlists found : " + playlist_ids.Count);
            Console.WriteLine("[*] Playlists IDs : " + s);
            Console.WriteLine("");

        }

        
        public void export_playlist(uint playlist_id)
        {
            if (playlist_id < 1 || playlist_id > 0xFFFFFFFF)
            {
                Console.WriteLine("Soundbank : Invalid playlist ID in export");
                return;
            }

            SBObject playlist = null;
            foreach (var obj in _objects._objects)
            {
                if (obj._type == SBObject.TYPE_MUSIC_PLAYLIST)
                {
                    if (obj._id == playlist_id)
                    {
                        playlist = obj;
                        break;
                    }
                }
            }

            if (playlist == null)
            {
                Console.WriteLine("Playlist " + playlist_id + " not found within soundbank");
                return;
            }

            var playlist_file = playlist_id + "_playlist.ini";
            playlist._obj_mpo.export(playlist_file);
        }

        // need to check for moveSegment
        public void reimport_playlist(uint playlist_id)
        {
            if (playlist_id < 1 || playlist_id > 0xFFFFFFFF)
            {
                Console.WriteLine("Soundbank : Invalid playlist ID in reimport");
                return;
            }

            SBObject playlist = null;
            int playlistIdx = -1;
            int i = 0;
            List<uint> playlistSegids = new List<uint>();
            foreach (var obj in _objects._objects)
            {
                if (obj._type == SBObject.TYPE_MUSIC_PLAYLIST)
                {
                    if (obj._id == playlist_id)
                    {
                        playlist = obj;
                        playlistIdx = i;
                        playlistSegids = obj._obj_mpo._segment_ids;
                        break;
                    }
                }
                i++;
            }
            if (playlist == null)
            {
                Console.WriteLine("Playlist " + playlist_id + " not found within soundbank");
                return;
            }

            var playlist_file = playlist_id + "_playlist.ini";
            List<uint> moveSegs = playlist._obj_mpo.reimport(playlist_file);
            playlist.calculateLength();

            /*
            if(moveSegs != null && moveSegs.Count > 0)
            {
                SBObject baseSeg = null;
                foreach(var obj in _objects._objects)
                {
                    if(obj._type == SBObject.TYPE_MUSIC_SEGMENT)
                    {
                        if(playlistSegids.Contains(obj._id) && !moveSegs.Contains(obj._id))
                        {
                            baseSeg = obj;
                            break;
                        }
                    }
                }

                if(baseSeg == null)
                {
                    Console.WriteLine("Soundbank : No base segment within playlist");
                    return;
                }
                foreach(var segid in moveSegs)
                {
                    i = 0;
                    SBObject segment = null;
                    int segmentIdx = -1;
                    foreach(var obj in _objects._objects)
                    {
                        if(obj._type == SBObject.TYPE_MUSIC_SEGMENT && obj._id == segid)
                        {
                            segment = obj;
                            segmentIdx = i;
                            break;
                        }
                    }
                    if(segment == null)
                    {
                        Console.WriteLine("Soundbank : Failed to find playlist's music segment within soundbank");
                        return;
                    }
                    if (segmentIdx < playlistIdx)
                        continue;

                    SBObject seg = baseSeg;
                    seg._id = segment._id;
                    seg._obj_mso._children = segment._obj_mso._children;
                    seg._obj_mso._child_ids = segment._obj_mso._child_ids;
                    seg._obj_mso._unk_double_1 = segment._obj_mso._unk_double_1;
                    seg._obj_mso._unk_field64_1 = segment._obj_mso._unk_field64_1;
                    seg._obj_mso._unk_field64_2 = segment._obj_mso._unk_field64_2;
                    seg._obj_mso._time_length = segment._obj_mso._time_length;
                    seg._obj_mso._time_length_next = segment._obj_mso._time_length_next;
                    seg.calculateLength();
                    segment = seg;

                    List<int> tracks = new List<int>();
                    i = 0;
                    foreach(var obj in _objects._objects)
                    {
                    }
                }

            }
            */
        }

        
        public void build_bnk()
        {
            if (_isInit)
            {
                Console.WriteLine("Soundbank : Rebuilding init.bnk is not yet supported");
                return;
            }

            FileWrite fw = new FileWrite(_fileName + ".wkrebuilt");
            fw._file.Write(_header._head.ToCharArray());
            fw._file.Write((UInt32)_header._length);
            fw._file.Write((UInt32)_header._version);
            fw._file.Write((UInt32)_header._id);
            fw._file.Write((UInt32)_header._unk_field32_1);
            fw._file.Write((UInt32)_header._unk_field32_2);

            if(_header._unk_data != "")
            {
                fw._file.Write(_header._unk_data.ToCharArray());
            }

            if(_dataIndex != null && _dataIndex._isSet)
            {
                _dataIndex.calculate_offset();
                fw._file.Write(_dataIndex._head.ToCharArray());
                fw._file.Write((UInt32)_dataIndex._length);

                foreach(var info in _dataIndex._data_info)
                {
                    fw._file.Write((UInt32)info._id);
                    fw._file.Write((UInt32)info._offset);
                    fw._file.Write((UInt32)info._size);
                }
            }
            if(_data != null && _data._isSet)
            {
                fw._file.Write(_data._head.ToCharArray());
                fw._file.Write((UInt32)_dataIndex.get_total_size());

                _data._offset = (uint)fw.getPosition();
                foreach(var info in _dataIndex._data_info)
                {
                    fw._file.Write(info._data.ToCharArray());
                }
            }

            fw._file.Write(_objects._head.ToCharArray());
            fw._file.Write((UInt32)_objects._length);
            fw._file.Write((UInt32)_objects._quantity);

            foreach(var obj in _objects._objects)
            {
                fw._file.Write((UInt32)obj._type);
                fw._file.Write((UInt32)obj._length);
                fw._file.Write((UInt32)obj._id);

                if(obj._type == SBObject.TYPE_SOUND)
                {
                    if(obj._obj_so._include_type == SBSoundObject.SOUND_EMBEDED && _dataIndex != null && _dataIndex._isSet)
                    {
                        uint offset = obj._obj_so._offset;
                        uint size = obj._obj_so._size;
                        bool bSet = true;
                        try
                        {
                            offset = _data._offset + (uint)_dataIndex.get_offset(obj._obj_so._audio_id);
                            size = (uint)_dataIndex.get_size(obj._obj_so._audio_id);
                        }
                        catch
                        {
                            bSet = false;
                        }
                        if (bSet)
                        {
                            obj._obj_so._offset = offset;
                            obj._obj_so._size = size;
                        }
                        
                    }
                }

                fw._file.Write(obj.getData().ToCharArray());
            }

            if(_stid != null && _stid._isSet)
            {
                fw._file.Write(_stid._head.ToCharArray());
                fw._file.Write((UInt32)_stid._length);
                fw._file.Write((UInt32)_stid._unk_field32_1);
                fw._file.Write((UInt32)_stid._quantity);
                fw._file.Write(_stid._remaining.ToCharArray());
            }

            fw._file.Close();
        }

        
        public void read_wems(string folder)
        {
            string[] files = Directory.GetFiles(folder, "*.wem", SearchOption.AllDirectories);
            foreach(string f in files)
            {
                try
                {
                    FileInfo fi = new FileInfo(f);
                    WEM w = new WEM();
                    //TODO: Add soundbanksinfo reversing here
                    uint.TryParse(Path.GetFileNameWithoutExtension(f), out w._id);
                    w._size = (UInt32)fi.Length;
                    BinaryReader br = new BinaryReader(fi.OpenRead());
                    w._data = new String(br.ReadChars((int)br.BaseStream.Length));
                    _to_add.Add(w);
                    Console.WriteLine("\tFile ->" + f);
                }
                catch
                {
                    continue;
                }
            }
        }

        
        public void rebuild_music(string file)
        {
            
            uint mid = 0;
            if(!uint.TryParse(Path.GetFileNameWithoutExtension(file), out mid))
            {
                Console.WriteLine("Soundbank : rebuild_music -- wrong file");
                return;
            }
            if(mid < 1 || mid > 0xFFFFFFFF)
            {
                Console.WriteLine("Soundbank : rebuild_music -- Invalid WEM ID");
                return;
            }

            WemFile wem = new WemFile();
            wem.LoadFromFile(file, WwAudioFileType.Wem);

            double new_time = (wem.sample_count / (float)wem.sample_rate) * 1000;

            Dictionary<uint, List<uint>> trackids = new Dictionary<uint, List<uint>>();
            uint i = 0;

            foreach(var obj in _objects._objects)
            {
                if(obj._type == SBObject.TYPE_MUSIC_TRACK)
                {
                    if(obj._obj_mto._id1 == mid)
                    {
                        List<uint> v = new List<uint> { i, 0};
                        trackids.Add(obj._id, v);
                    }
                }
                i++;
            }
            if(trackids.Count == 0)
            {
                Console.WriteLine("Could not find ID " + mid + " within soundbank -- rebuild_music");
                return;
            }
            foreach(var obj in _objects._objects)
            {
                if(obj._type == SBObject.TYPE_MUSIC_SEGMENT)
                {
                    if(obj._obj_mso._child_ids.Count == 1)
                    {
                        obj._obj_mso._unk_double_1 = 1000;
                        obj._obj_mso._unk_field64_1 = 0;
                        obj._obj_mso._unk_field64_2 = 0;
                        obj._obj_mso._time_length = new_time;
                        obj._obj_mso._time_length_next = new_time;
                        trackids[obj._obj_mso._child_ids[0]][1] = obj._id;
                    }
                    else
                    {
                        long hasTrack = -1;
                        foreach (var trackid in trackids)
                        {
                            if(obj._obj_mso._child_ids.Contains(trackid.Key))
                            {
                                hasTrack = (long)trackid.Key;
                            }
                        }
                        if(hasTrack != -1)
                        {
                            obj._obj_mso._children = 1;
                            obj._obj_mso._child_ids = new List<uint>();
                            obj._obj_mso._child_ids.Add((uint)hasTrack);
                            obj._obj_mso._unk_double_1 = 1000;
                            obj._obj_mso._unk_field64_1 = 0;
                            obj._obj_mso._unk_field64_2 = 0;
                            obj._obj_mso._time_length = new_time;
                            obj._obj_mso._time_length_next = new_time;
                            obj.calculateLength();
                            trackids[(uint)hasTrack][1] = obj._id;
                        }
                    }
                }
            }
        
            foreach(var t in trackids)
            {
                if(t.Value[1] != 0)
                {
                    _objects._objects[(int)t.Value[0]]._obj_mto_custom = new SBMusicTrackCustomObject(mid, new_time, t.Value[1]);
                    _objects._objects[(int)t.Value[0]].calculateLength();
                }
            }

            _objects.calculate_length();
        }

        
        public uint add_music(string file)
        {
            string s = Path.GetFileNameWithoutExtension(file);
            uint mid = 0;
            if(!uint.TryParse(s, out mid))
            {
                Console.WriteLine("Soundbank : add_music -- Invalid WEM ID");
                Environment.Exit(0);
            }
            if(mid < 1 || mid > 0xFFFFFFFF)
            {
                Console.WriteLine("Soundbank : add_music -- Invalid WEM ID");
                Environment.Exit(0);
            }

            WemFile wem = new WemFile();
            wem.LoadFromFile(file, WwAudioFileType.Wem);

            double new_time = (wem.sample_count / wem.sample_rate) * 1000;
            SBObject segment = null;
            foreach(var obj in _objects._objects)
            {
                if(obj._type == SBObject.TYPE_MUSIC_TRACK)
                {
                    if(obj._obj_mto._id1 == mid)
                    {
                        Console.WriteLine("Add new music : ID " + mid + " is already used");
                        Environment.Exit(0);
                    }
                }
                else if(obj._type == SBObject.TYPE_MUSIC_SEGMENT)
                {
                    if(segment == null)
                    {
                        segment = obj;
                    }
                }
            }
            if(segment != null)
            {
                Console.WriteLine("No music segments within the soundbank");
                Environment.Exit(0);
            }

            uint musicTrackId = _objects.get_new_id();
            SBObject musicTrackObject = new SBObject();
            musicTrackObject._type = SBObject.TYPE_MUSIC_TRACK;
            musicTrackObject._id = musicTrackId;
            musicTrackObject._obj_mto_custom = new SBMusicTrackCustomObject(mid, new_time, 0);
            musicTrackObject._current_obj = "MusicTrackCustom";
            musicTrackObject.calculateLength();

            _objects._objects.Add(musicTrackObject);

            uint musicSegmentId = _objects.get_new_id();
            musicTrackObject._obj_mto_custom._parent = musicSegmentId;

            SBObject musicSegmentObject = segment;
            musicSegmentObject._id = musicSegmentId;
            musicSegmentObject._obj_mso._children = 1;
            musicSegmentObject._obj_mso._child_ids = new List<uint>();
            musicSegmentObject._obj_mso._child_ids.Add(musicTrackId);
            musicSegmentObject._obj_mso._unk_double_1 = 1000;
            musicSegmentObject._obj_mso._unk_field64_1 = 0;
            musicSegmentObject._obj_mso._unk_field64_2 = 0;
            musicSegmentObject._obj_mso._time_length = new_time;
            musicSegmentObject._obj_mso._time_length_next = new_time;
            musicSegmentObject._obj_mso._sound_structure._parent_id = 0;
            musicSegmentObject.calculateLength();

            _objects._objects.Add(musicSegmentObject);
            _objects.calculate_length();

            return musicSegmentId;
        }
    }
}
