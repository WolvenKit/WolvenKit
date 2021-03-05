using System;
using System.Collections.Generic;
using System.IO;
using IniParser;
using IniParser.Model;

namespace WolvenKit.Wwise.Wwise
{
    public class EventAction_Additional
    {
        #region Fields

        public byte _type = 0;
        public float _value_f = 0;
        public uint _value_u = 0;

        #endregion Fields

        #region Constructors

        public EventAction_Additional(FileRead fr = null)
        {
            if (fr != null)
            {
                _type = fr.read_one_byte();
            }
        }

        #endregion Constructors
    }

    public class MusicPlaylistObject_PlaylistElement
    {
        #region Fields

        public const uint SIZE = 0x1A;

        public uint _child_elements = 0;
        public uint _id = 0;
        public ushort _loop_count = 0;
        public uint _music_segment_id = 0;
        public int _playlist_type = 0;
        public byte _random_type = 0;
        public ushort _times_in_row = 0;
        public byte _unk_field8_1 = 1;
        public uint _weight = 0;

        #endregion Fields

        #region Constructors

        public MusicPlaylistObject_PlaylistElement(FileRead fr = null)
        {
            if (fr != null)
            {
                _music_segment_id = fr.read_uint32();
                _id = fr.read_uint32();
                _child_elements = fr.read_uint32();
                _playlist_type = fr.read_int32();
                _loop_count = fr.read_uint16();
                _weight = fr.read_uint32();
                _times_in_row = fr.read_uint16();
                _unk_field8_1 = fr.read_one_byte();
                _random_type = fr.read_one_byte();
            }
        }

        #endregion Constructors
    }

    public class MusicPlaylistObject_Transition
    {
        #region Fields

        public int _dest_fadein = 0;
        public int _dest_fadein_offset = 0;
        public uint _dest_id = 0;
        public uint _dest_shape_curve_fadein = 0;
        public byte _dest_type = 0;
        public bool _has_segment = false;
        public int _source_fadeout = 0;
        public int _source_fadeout_offset = 0;
        public uint _source_id = 0;
        public uint _source_shape_curve_fadeout = 0;
        public byte _src_type = 0;
        public int _trans_fadein = 0;
        public int _trans_fadein_offset = 0;
        public byte _trans_fadein_type = 0;
        public int _trans_fadeout = 0;
        public int _trans_fadeout_offset = 0;
        public byte _trans_fadeout_type = 0;
        public uint _trans_segment_id = 0;
        public uint _trans_shape_curve_fadein = 0;
        public uint _trans_shape_curve_fadeout = 0;
        public ushort _unk_field16_1 = 0;
        public uint _unk_field32_1 = 0;
        public uint _unk_field32_2 = 0;
        public uint _unk_field32_3 = 7;
        public uint _unk_field32_4 = 0;
        public uint _unk_field32_5 = 0;
        public byte _unk_field8_1 = 0;

        #endregion Fields

        #region Constructors

        public MusicPlaylistObject_Transition(FileRead fr = null)
        {
            if (fr != null)
            {
                _source_id = fr.read_uint32();
                _dest_id = fr.read_uint32();
                _source_fadeout = fr.read_int32();
                _source_shape_curve_fadeout = fr.read_uint32();
                _source_fadeout_offset = fr.read_int32();
                _unk_field32_1 = fr.read_uint32();
                _unk_field32_2 = fr.read_uint32();
                _unk_field32_3 = fr.read_uint32();
                _src_type = fr.read_one_byte();
                _dest_fadein = fr.read_int32();
                _dest_shape_curve_fadein = fr.read_uint32();
                _dest_fadein_offset = fr.read_int32();
                _unk_field32_4 = fr.read_uint32();
                _unk_field32_5 = fr.read_uint32();
                _unk_field16_1 = fr.read_uint16();
                _dest_type = fr.read_one_byte();
                _unk_field8_1 = fr.read_one_byte();
                _has_segment = fr.read_bool();
                _trans_segment_id = fr.read_uint32();
                _trans_fadein = fr.read_int32();
                _trans_shape_curve_fadein = fr.read_uint32();
                _trans_fadein_offset = fr.read_int32();
                _trans_fadeout = fr.read_int32();
                _trans_shape_curve_fadeout = fr.read_uint32();
                _trans_fadeout_offset = fr.read_int32();
                _trans_fadein_type = fr.read_one_byte();
                _trans_fadeout_type = fr.read_one_byte();
            }
        }

        #endregion Constructors
    }

    public class SBData
    {
        #region Fields

        public const string HEAD = "DATA";

        public List<WEM> _data;
        public string _head = HEAD;
        public bool _isSet = true;
        public uint _length = 0;
        public uint _offset = 0;

        #endregion Fields

        #region Constructors

        public SBData(FileRead fr = null)
        {
            _data = new List<WEM>();
            if (fr != null)
            {
                _head = fr.read_header();

                if (_head != HEAD)
                {
                    _head = "";
                    fr.seekPosition(-4, 1);
                    _isSet = false;
                    return;
                }

                _length = fr.read_uint32();
                _offset = (uint)fr.getPosition();
            }
        }

        #endregion Constructors

        #region Methods

        public void read_data(FileRead fr, SBDataIndex dataIndex)
        {
            foreach (WEM w in dataIndex._data_info)
            {
                fr.seekPosition(_offset + w._offset);
                w._data = fr._file.ReadBytes((int)w._size);
            }

            fr.seekPosition(_offset + _length);
            _data = dataIndex._data_info;
        }

        #endregion Methods
    }

    public class SBDataIndex
    {
        #region Fields

        public const string HEAD = "DIDX";
        public List<WEM> _data_info = new List<WEM>();
        public FileRead _fr;
        public string _head = HEAD;
        public bool _isSet = true;
        public uint _length = 0;

        #endregion Fields

        #region Constructors

        public SBDataIndex(FileRead fr = null)
        {
            if (fr != null)
            {
                _head = fr.read_header();
                if (_head != HEAD)
                {
                    _head = "";
                    fr.seekPosition(-4, 1);
                    _isSet = false;
                    return;
                }
                _length = fr.read_uint32();
                if (_length % 12 != 0)
                {
                    Console.WriteLine("SBDataIndex: Invalid file length, exiting.");
                    Environment.Exit(0);
                }
                // wem file
                for (int i = 0; i < _length; i += 12)
                {
                    _data_info.Add(new WEM(fr));
                }
            }
        }

        #endregion Constructors

        #region Methods

        public void calculate_offset()
        {
            uint offset = 0;

            foreach (WEM w in _data_info)
            {
                w._offset = offset;
                offset += w._offset;
            }
        }

        public uint? get_offset(uint id)
        {
            for (int i = 0; i < _data_info.Count; i++)
            {
                if (_data_info[i]._id == id)
                {
                    return _data_info[i]._offset;
                }
            }
            return null;
        }

        public uint? get_size(uint id)
        {
            for (int i = 0; i < _data_info.Count; i++)
            {
                if (_data_info[i]._id == id)
                {
                    return _data_info[i]._size;
                }
            }
            return null;
        }

        public uint get_total_size()
        {
            uint sum = 0;
            for (int i = 0; i < _data_info.Count; i++)
            {
                sum += _data_info[i]._size;
            }
            return sum;
        }

        #endregion Methods
    }

    public class SBEnvironments
    {
        #region Fields

        public const string HEAD = "ENVS";

        public string _head = HEAD;
        public bool _isSet = true;
        public uint _length = 0;
        public byte[] _unk_data = null;

        #endregion Fields

        #region Constructors

        public SBEnvironments(FileRead fr = null)
        {
            if (fr != null)
            {
                _head = fr.read_header();
                if (_head != HEAD)
                {
                    Console.WriteLine("SBEnvironments: Invalid header.");
                    _isSet = false;
                    return;
                }
                _length = fr.read_uint32();
                _unk_data = fr._file.ReadBytes((int)_length);
            }
        }

        #endregion Constructors
    }

    public class SBEventActionObject
    {
        #region Fields

        public const uint ACTION_TYPE_SET_STATE = 0x12;
        public const uint ACTION_TYPE_SET_SWITCH = 0x19;

        public List<EventAction_Additional> _additional_parameters = new List<EventAction_Additional>();
        public byte _additional_parameters_count = 0;
        public uint _game_object_id = 0;
        public byte _scope = 0;
        public uint _state_group_id = 0;
        public uint _state_id = 0;
        public uint _switch_group_id = 0;
        public uint _switch_id = 0;
        public byte _type = 0;
        public ushort _unk_field16_1 = 0;
        public uint _unk_field32_1 = 0;
        public uint _unk_field32_2 = 0;
        public byte _unk_field8_1 = 0;
        public byte _unk_field8_2 = 0;
        public byte _unk_field8_3 = 0;

        #endregion Fields

        #region Constructors

        public SBEventActionObject(FileRead fr = null)
        {
            _additional_parameters = new List<EventAction_Additional>();
            if (fr != null)
            {
                _scope = fr.read_one_byte();
                _type = fr.read_one_byte();
                _game_object_id = fr.read_uint32();
                _unk_field8_1 = fr.read_one_byte();

                _additional_parameters_count = fr.read_one_byte();
                if (_additional_parameters_count > 0)
                {
                    for (int i = 0; i < _additional_parameters_count; i++)
                    {
                        _additional_parameters.Add(new EventAction_Additional(fr));
                    }

                    foreach (EventAction_Additional ea in _additional_parameters)
                    {
                        if (ea._type == 0x01)
                        {
                            ea._value_f = fr.read_float();
                            ea._value_u = 0;
                        }
                        else
                        {
                            ea._value_f = 0;
                            ea._value_u = fr.read_uint32();
                        }
                    }
                }

                _unk_field8_2 = fr.read_one_byte();

                if (_type == ACTION_TYPE_SET_STATE)
                {
                    _state_group_id = fr.read_uint32();
                    _state_id = fr.read_uint32();
                }
                else if (_type == ACTION_TYPE_SET_SWITCH)
                {
                    _switch_group_id = fr.read_uint32();
                    _switch_id = fr.read_uint32();
                }
                else if (_type == 0x01)
                {
                    _unk_field32_1 = fr.read_uint32();
                    _unk_field16_1 = fr.read_uint16();
                    _unk_field32_2 = fr.read_uint32();
                }
                else if (_type == 0x04)
                {
                    _unk_field32_1 = fr.read_uint32();
                    _unk_field8_3 = fr.read_one_byte();
                }
            }
        }

        #endregion Constructors
    }

    public class SBEventObject
    {
        #region Fields

        public List<uint> _event_action_ids = new List<uint>();
        public uint _event_actions = 0;

        #endregion Fields

        #region Constructors

        public SBEventObject(FileRead fr = null)
        {
            _event_action_ids = new List<uint>();
            if (fr != null)
            {
                _event_actions = fr.read_uint32();
                for (int i = 0; i < _event_actions; i++)
                {
                    _event_action_ids.Add(fr.read_uint32());
                }
            }
        }

        #endregion Constructors
    }

    public class SBHeader
    {
        #region Fields

        public const string HEAD = "BKHD";
        public const uint VERSION = 0x58;

        public string _head = HEAD;
        public uint _id = 0;
        public uint _length = 0;
        public long _offset = 0;
        public byte[] _unk_data = null;
        public uint _unk_field32_1 = 0;
        public uint _unk_field32_2 = 0;
        public uint _version = VERSION;

        #endregion Fields

        #region Constructors

        public SBHeader(FileRead fr = null)
        {
            if (fr != null)
            {
                _head = fr.read_header();
                if (_head != HEAD)
                {
                    Console.WriteLine("Invalid header, exiting.");
                    Environment.Exit(0);
                }
                _length = fr.read_uint32();
                long curPos = fr.getPosition();

                _version = fr.read_uint32();

                if (_version != VERSION)
                {
                    Console.Write("Invalid version, exiting.");
                    Environment.Exit(0);
                }

                _id = fr.read_uint32();
                _unk_field32_1 = fr.read_uint32();
                _unk_field32_2 = fr.read_uint32();

                uint remaining = _length - (uint)(fr.getPosition() - curPos);

                if (remaining > 0)
                {
                    _unk_data = fr._file.ReadBytes((int)remaining);
                }
                else
                {
                    _unk_data = null;
                }
            }
        }

        #endregion Constructors
    }

    public class SBManager
    {
        #region Fields

        public const string HEAD = "STMG";

        public List<ManagerObject_GameParameter> _game_parameters = new List<ManagerObject_GameParameter>();
        public uint _game_parameters_count = 0;
        public string _head = HEAD;
        public bool _isSet = true;
        public uint _length = 0;
        public ushort _max_voice_instances = 0;
        public List<ManagerObject_StateGroup> _state_groups = new List<ManagerObject_StateGroup>();
        public uint _state_groups_count = 0;
        public List<ManagerObject_SwitchGroup> _switch_groups = new List<ManagerObject_SwitchGroup>();
        public uint _switch_groups_count = 0;
        public float _volume = 0;

        #endregion Fields

        #region Constructors

        public SBManager(FileRead fr = null)
        {
            if (fr != null)
            {
                _head = fr.read_header();

                if (_head != SBManager.HEAD)
                {
                    Console.WriteLine("SBManger: Invalid header");
                    _isSet = false;
                    return;
                }

                _length = fr.read_uint32();
                _volume = fr.read_float();
                _max_voice_instances = fr.read_uint16();

                _state_groups_count = fr.read_uint32();
                for (int i = 0; i < _state_groups_count; i++)
                {
                    _state_groups.Add(new ManagerObject_StateGroup(fr));
                }

                _switch_groups_count = fr.read_uint32();
                for (int i = 0; i < _switch_groups_count; i++)
                {
                    _switch_groups.Add(new ManagerObject_SwitchGroup(fr));
                }

                _game_parameters_count = fr.read_uint32();
                for (int i = 0; i < _game_parameters_count; i++)
                {
                    _game_parameters.Add(new ManagerObject_GameParameter(fr));
                }
            }
        }

        #endregion Constructors
    }

    public class SBMusicPlaylistObject
    {
        #region Fields

        public List<MusicPlaylistObject_PlaylistElement> _playlist_elements = new List<MusicPlaylistObject_PlaylistElement>();
        public uint _playlist_elements_count = 0;
        public List<uint> _segment_ids = new List<uint>();
        public uint _segments = 0;
        public SoundStructure _sound_structure = null;
        public float _tempo = 0;
        public byte _time_sig1 = 0;
        public byte _time_sig2 = 0;
        public uint _transition_count = 0;
        public List<MusicPlaylistObject_Transition> _transitions = new List<MusicPlaylistObject_Transition>();
        public double _unk_double_1 = 0;
        public uint _unk_field32_1 = 0;
        public ulong _unk_field64_1 = 0;
        public byte _unk_field8_1 = 0;

        #endregion Fields

        #region Constructors

        public SBMusicPlaylistObject(FileRead fr = null, long curPos = 0, uint length = 0)
        {
            if (fr != null)
            {
                _sound_structure = new SoundStructure(fr);
                _segments = fr.read_uint32();
                for (int i = 0; i < _segments; i++)
                {
                    _segment_ids.Add(fr.read_uint32());
                }
                _unk_double_1 = fr.read_double();
                _unk_field64_1 = fr.read_uint64();
                _tempo = fr.read_float();
                _time_sig1 = fr.read_one_byte();
                _time_sig2 = fr.read_one_byte();
                _unk_field8_1 = fr.read_one_byte();
                _unk_field32_1 = fr.read_uint32();

                _transition_count = fr.read_uint32();
                for (int i = 0; i < _transition_count; i++)
                {
                    _transitions.Add(new MusicPlaylistObject_Transition(fr));
                }

                _playlist_elements_count = fr.read_uint32();

                uint element_count = (length - (uint)(fr.getPosition() - curPos)) / MusicPlaylistObject_PlaylistElement.SIZE;
                for (int i = 0; i < element_count; i++)
                {
                    _playlist_elements.Add(new MusicPlaylistObject_PlaylistElement(fr));
                }
            }
        }

        #endregion Constructors

        #region Methods

        public void export(string file)
        {
            var parser = new FileIniDataParser();
            IniData data = new IniData();
            int i = 1;
            foreach (var s in _segment_ids)
            {
                data["SEGMENTS"]["segment" + i] = s.ToString();
                i++;
            }
            i = 1;
            foreach (var t in _transitions)
            {
                string seg = "TRANSITION" + i;
                data[seg]["source_id"] = t._source_id.ToString();
                data[seg]["dest_id"] = t._dest_id.ToString();
                data[seg]["source_fadeout"] = t._source_fadeout.ToString();
                data[seg]["source_shape_curve_fadeout"] = t._source_shape_curve_fadeout.ToString();
                data[seg]["source_fadeout_offset"] = t._source_fadeout_offset.ToString();
                data[seg]["unk_field_32_1"] = t._unk_field32_1.ToString();
                data[seg]["unk_field_32_2"] = t._unk_field32_2.ToString();
                data[seg]["unk_field_32_3"] = t._unk_field32_3.ToString();
                data[seg]["src_type"] = t._src_type.ToString();
                data[seg]["dest_fadein"] = t._dest_fadein.ToString();
                data[seg]["dest_shape_curve_fadein"] = t._dest_shape_curve_fadein.ToString();
                data[seg]["dest_fadein_offset"] = t._dest_fadein_offset.ToString();
                data[seg]["unk_field32_4"] = t._unk_field32_4.ToString();
                data[seg]["unk_field32_5"] = t._unk_field32_5.ToString();
                data[seg]["unk_field16_1"] = t._unk_field16_1.ToString();
                data[seg]["dest_type"] = t._dest_type.ToString();
                data[seg]["unk_field8_1"] = t._unk_field8_1.ToString();
                data[seg]["has_segment"] = t._has_segment.ToString();
                data[seg]["trans_segment_id"] = t._trans_segment_id.ToString();
                data[seg]["trans_fadein"] = t._trans_fadein.ToString();
                data[seg]["trans_shape_curve_fadein"] = t._trans_shape_curve_fadein.ToString();
                data[seg]["trans_fadein_offset"] = t._trans_fadein_offset.ToString();
                data[seg]["trans_fadeout"] = t._trans_fadeout.ToString();
                data[seg]["trans_shape_curve_fadeout"] = t._trans_shape_curve_fadeout.ToString();
                data[seg]["trans_fadeout_offset"] = t._trans_fadeout_offset.ToString();
                data[seg]["trans_fadein_type"] = t._trans_fadein_type.ToString();
                data[seg]["trans_fadeout_type"] = t._trans_fadeout_type.ToString();
                i++;
            }

            i = 1;
            foreach (var p in _playlist_elements)
            {
                string seg = "PLAYLIST ELEMENT" + i;
                data[seg]["music_segment_id"] = p._music_segment_id.ToString();
                data[seg]["id"] = p._id.ToString();
                data[seg]["child_elements"] = p._child_elements.ToString();
                data[seg]["playlist_type"] = p._playlist_type.ToString();
                data[seg]["loop_count"] = p._loop_count.ToString();
                data[seg]["weight"] = p._weight.ToString();
                data[seg]["times_in_row"] = p._times_in_row.ToString();
                data[seg]["unk_field8_1"] = p._unk_field8_1.ToString();
                data[seg]["random_type"] = p._random_type.ToString();
                i++;
            }

            var res = data.ToString();
            parser.WriteFile(file, data);
        }

        public byte[] getData()
        {
            var ms = new MemoryStream();
            FileWrite fr = new FileWrite(ms);

            fr._file.Write(_sound_structure.getData());
            fr._file.Write(_segments);
            foreach (uint id in _segment_ids)
            {
                fr._file.Write(id);
            }
            fr._file.Write(_unk_double_1);
            fr._file.Write(_unk_field64_1);
            fr._file.Write(_tempo);
            fr._file.Write(_time_sig1);
            fr._file.Write(_time_sig2);
            fr._file.Write(_unk_field8_1);
            fr._file.Write(_transition_count);

            foreach (MusicPlaylistObject_Transition mt in _transitions)
            {
                fr._file.Write(mt._source_id);
                fr._file.Write(mt._dest_id);
                fr._file.Write(mt._source_fadeout);
                fr._file.Write(mt._source_shape_curve_fadeout);
                fr._file.Write(mt._source_fadeout_offset);
                fr._file.Write(mt._unk_field32_1);
                fr._file.Write(mt._unk_field32_2);
                fr._file.Write(mt._unk_field32_3);
                fr._file.Write(mt._src_type);
                fr._file.Write(mt._dest_fadein);
                fr._file.Write(mt._dest_shape_curve_fadein);
                fr._file.Write(mt._dest_fadein_offset);
                fr._file.Write(mt._unk_field32_4);
                fr._file.Write(mt._unk_field32_5);
                fr._file.Write(mt._unk_field16_1);
                fr._file.Write(mt._dest_type);
                fr._file.Write(mt._unk_field8_1);
                fr._file.Write(mt._has_segment);
                fr._file.Write(mt._trans_segment_id);
                fr._file.Write(mt._trans_fadein);
                fr._file.Write(mt._trans_shape_curve_fadein);
                fr._file.Write(mt._trans_fadein_offset);
                fr._file.Write(mt._trans_fadeout);
                fr._file.Write(mt._trans_shape_curve_fadeout);
                fr._file.Write(mt._trans_fadeout_offset);
                fr._file.Write(mt._trans_fadein_type);
                fr._file.Write(mt._trans_fadeout_type);
            }

            fr._file.Write(_playlist_elements_count);

            foreach (MusicPlaylistObject_PlaylistElement mp in _playlist_elements)
            {
                fr._file.Write(mp._music_segment_id);
                fr._file.Write(mp._id);
                fr._file.Write(mp._child_elements);
                fr._file.Write(mp._playlist_type);
                fr._file.Write(mp._loop_count);
                fr._file.Write(mp._weight);
                fr._file.Write(mp._times_in_row);
                fr._file.Write(mp._unk_field8_1);
                fr._file.Write(mp._random_type);
            }

            byte[] result = ms.ToArray();
            fr._file.Close();

            return result;
        }

        public uint getNewElementId()
        {
            int nid = -1;
            RandomGen rnd = new RandomGen();
            while (nid == -1)
            {
                nid = (int)rnd.uint32();
                foreach (MusicPlaylistObject_PlaylistElement mp in _playlist_elements)
                {
                    if (mp._id == nid)
                    {
                        nid = -1;
                        break;
                    }
                }
            }
            return (uint)nid;
        }

        public List<uint> reimport(string file)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(file);

            List<uint> segments = new List<uint>();
            List<uint> moveSegments = new List<uint>();
            List<MusicPlaylistObject_Transition> transitions = new List<MusicPlaylistObject_Transition>();
            List<MusicPlaylistObject_PlaylistElement> playlist_elements = new List<MusicPlaylistObject_PlaylistElement>();

            foreach (var s in data.Sections)
            {
                if (s.SectionName == "SEGMENTS")
                {
                    foreach (KeyData k in s.Keys)
                    {
                        uint s_id = 0;
                        if (uint.TryParse(k.Value, out s_id))
                        {
                            segments.Add(s_id);
                        }
                    }
                }
                else if (s.SectionName == "MOVE SEGMENTS")
                {
                    // store move segment
                    foreach (KeyData k in s.Keys)
                    {
                        uint m_id = 0;
                        if (uint.TryParse(k.Value, out m_id))
                        {
                            moveSegments.Add(m_id);
                        }
                    }
                }
                else if (s.SectionName.StartsWith("TRANSITION"))
                {
                    MusicPlaylistObject_Transition t = new MusicPlaylistObject_Transition();
                    uint.TryParse(s.Keys["source_id"], out t._source_id);
                    uint.TryParse(s.Keys["dest_id"], out t._dest_id);
                    int.TryParse(s.Keys["source_fadeout"], out t._source_fadeout);
                    uint.TryParse(s.Keys["source_shape_curve_fadeout"], out t._source_shape_curve_fadeout);
                    int.TryParse(s.Keys["source_fadeout_offset"], out t._source_fadeout_offset);
                    uint.TryParse(s.Keys["unk_field32_1"], out t._unk_field32_1);
                    uint.TryParse(s.Keys["unk_field32_2"], out t._unk_field32_2);
                    uint.TryParse(s.Keys["unk_field32_3"], out t._unk_field32_3);
                    byte.TryParse(s.Keys["src_type"], out t._src_type);
                    int.TryParse(s.Keys["dest_fadein"], out t._dest_fadein);
                    uint.TryParse(s.Keys["dest_shape_curve_fadein"], out t._dest_shape_curve_fadein);
                    int.TryParse(s.Keys["dest_fadein_offset"], out t._dest_fadein_offset);
                    uint.TryParse(s.Keys["unk_field32_4"], out t._unk_field32_4);
                    uint.TryParse(s.Keys["unk_field32_5"], out t._unk_field32_5);
                    ushort.TryParse(s.Keys["unk_field16_1"], out t._unk_field16_1);
                    byte.TryParse(s.Keys["dest_type"], out t._dest_type);
                    byte.TryParse(s.Keys["unk_field8_1"], out t._unk_field8_1);
                    bool.TryParse(s.Keys["has_segment"], out t._has_segment);
                    uint.TryParse(s.Keys["trans_segment_id"], out t._trans_segment_id);
                    int.TryParse(s.Keys["trans_fadein"], out t._trans_fadein);
                    uint.TryParse(s.Keys["trans_shape_curve_fadein"], out t._trans_shape_curve_fadein);
                    int.TryParse(s.Keys["trans_fadein_offset"], out t._trans_fadein_offset);
                    int.TryParse(s.Keys["trans_fadeout"], out t._trans_fadeout);
                    uint.TryParse(s.Keys["trans_shape_curve_fadeout"], out t._trans_shape_curve_fadeout);
                    int.TryParse(s.Keys["trans_fadeout_offset"], out t._trans_fadeout_offset);
                    byte.TryParse(s.Keys["trans_fadein_type"], out t._trans_fadein_type);
                    byte.TryParse(s.Keys["trans_fadeout_type"], out t._trans_fadeout_type);

                    transitions.Add(t);
                }
                else if (s.SectionName.StartsWith("PLAYLIST ELEMENT"))
                {
                    MusicPlaylistObject_PlaylistElement p = new MusicPlaylistObject_PlaylistElement();
                    if (s.Keys["id"] == "<NEW ID>")
                    {
                        p._id = getNewElementId();
                    }
                    else
                    {
                        uint.TryParse(s.Keys["id"], out p._id);
                    }
                    uint.TryParse(s.Keys["child_elements"], out p._child_elements);
                    int.TryParse(s.Keys["playlist_type"], out p._playlist_type);
                    ushort.TryParse(s.Keys["loop_count"], out p._loop_count);
                    uint.TryParse(s.Keys["weight"], out p._weight);
                    ushort.TryParse(s.Keys["times_in_row"], out p._times_in_row);
                    byte.TryParse(s.Keys["unk_field8_1"], out p._unk_field8_1);
                    byte.TryParse(s.Keys["random_type"], out p._random_type);
                    playlist_elements.Add(p);
                }

                if (segments.Count > 0)
                {
                    _segment_ids = segments;
                    _segments = (uint)segments.Count;
                }

                if (transitions.Count > 0)
                {
                    _transitions = transitions;
                    _transition_count = (uint)transitions.Count;
                }

                if (playlist_elements.Count > 0)
                {
                    _playlist_elements = playlist_elements;
                    _playlist_elements_count = (uint)playlist_elements.Count;
                }
            }

            if (segments.Count > 0)
            {
                _segment_ids = segments;
                _segments = (uint)segments.Count;
            }
            if (transitions.Count > 0)
            {
                _transitions = transitions;
                _transition_count = (uint)transitions.Count;
            }
            if (playlist_elements.Count > 0)
            {
                _playlist_elements = playlist_elements;
                _playlist_elements_count = (uint)playlist_elements.Count;
            }
            return moveSegments;
        }

        #endregion Methods
    }

    public class SBMusicSegmentObject
    {
        #region Fields

        public List<uint> _child_ids = new List<uint>();
        public uint _children = 0;
        public SoundStructure _sound_structure = null;
        public float _tempo = 0;
        public double _time_length = 0;
        public double _time_length_next = 0;
        public byte _time_sig1 = 0;
        public byte _time_sig2 = 0;
        public byte[] _unk_data = null;
        public double _unk_double_1 = 0;
        public uint _unk_field32_1 = 0;
        public uint _unk_field32_2 = 0;
        public uint _unk_field32_3 = 0;
        public uint _unk_field32_4 = 0;
        public uint _unk_field32_5 = 0;
        public uint _unk_field32_6 = 0;

        public ulong _unk_field64_1 = 0;
        public ulong _unk_field64_2 = 0;

        public byte _unk_field8_1 = 0;

        #endregion Fields

        #region Constructors

        public SBMusicSegmentObject(FileRead fr = null, long curPos = 0, uint length = 0)
        {
            if (fr != null)
            {
                _sound_structure = new SoundStructure(fr);
                _children = fr.read_uint32();
                for (int i = 0; i < _children; i++)
                {
                    _child_ids.Add(fr.read_uint32());
                }
                _unk_double_1 = fr.read_double();
                _unk_field64_1 = fr.read_uint64();
                _tempo = fr.read_float();
                _time_sig1 = fr.read_one_byte();
                _time_sig2 = fr.read_one_byte();
                _unk_field32_1 = fr.read_uint32();
                _unk_field8_1 = fr.read_one_byte();
                _time_length = fr.read_double();
                _unk_field32_2 = fr.read_uint32();
                _unk_field32_3 = fr.read_uint32();
                _unk_field64_2 = fr.read_uint64();
                _unk_field32_4 = fr.read_uint32();
                _unk_field32_5 = fr.read_uint32();
                _time_length_next = fr.read_double();
                _unk_field32_6 = fr.read_uint32();

                uint remaining = (length - (uint)(fr.getPosition() - curPos));
                if (remaining > 0)
                {
                    _unk_data = fr._file.ReadBytes((int)remaining);
                }
                else
                {
                    _unk_data = null;
                }
            }
        }

        #endregion Constructors

        #region Methods

        public byte[] getData()
        {
            var ms = new MemoryStream();
            FileWrite fr = new FileWrite(ms);

            fr._file.Write(_sound_structure.getData().ToCharArray());
            fr._file.Write(_children);
            foreach (uint id in _child_ids)
            {
                fr._file.Write(id);
            }

            fr._file.Write(_unk_double_1);
            fr._file.Write(_unk_field64_1);
            fr._file.Write(_tempo);
            fr._file.Write(_time_sig1);
            fr._file.Write(_time_sig2);
            fr._file.Write(_unk_field32_1);
            fr._file.Write(_unk_field8_1);
            fr._file.Write(_time_length);
            fr._file.Write(_unk_field32_2);
            fr._file.Write(_unk_field32_3);
            fr._file.Write(_unk_field64_2);
            fr._file.Write(_unk_field32_4);
            fr._file.Write(_unk_field32_5);
            fr._file.Write(_time_length_next);
            fr._file.Write(_unk_field32_6);

            if (_unk_data != null)
                fr._file.Write(_unk_data);

            byte[] result = ms.ToArray();
            fr._file.Close();

            return result;
        }

        #endregion Methods
    }

    public class SBMusicTrackCustomObject
    {
        #region Fields

        public uint _id1 = 0;
        public uint _id2 = 0;
        public uint _id3 = 0;
        public uint _parent = 0;
        public double _time_length = 0;
        public ushort _unk_field16_1 = 0;
        public ushort _unk_field16_2 = 0;
        public uint _unk_field32_1 = 1;
        public uint _unk_field32_2 = 0x00040001;
        public uint _unk_field32_3 = 1;
        public uint _unk_field32_4 = 0x00000100;
        public uint _unk_field32_5 = 0;
        public uint _unk_field32_6 = 1;
        public uint _unk_field32_7 = 0;
        public uint _unk_field32_8 = 0x00000064;
        public ulong _unk_field64_1 = 0;
        public ulong _unk_field64_2 = 0;
        public ulong _unk_field64_3 = 0x8000000000000000;
        public ulong _unk_field64_4 = 0;
        public ulong _unk_field64_5 = 0;
        public ulong _unk_field64_6 = 0;
        public ulong _unk_field64_7 = 0;
        public byte _unk_field8_1 = 0;
        public byte _unk_field8_2 = 0;
        public byte _unk_field8_3 = 0;

        #endregion Fields

        #region Constructors

        public SBMusicTrackCustomObject(uint mid, double new_time, uint parent)
        {
            _id1 = mid;
            _id2 = mid;
            _id3 = mid;
            _time_length = new_time;
            _parent = parent;
        }

        #endregion Constructors

        #region Methods

        public byte[] getData()
        {
            var ms = new MemoryStream();
            FileWrite fr = new FileWrite(ms);

            fr._file.Write(_unk_field32_1);
            fr._file.Write(_unk_field32_2);
            fr._file.Write(_unk_field32_3);
            fr._file.Write(_id1);
            fr._file.Write(_id2);
            fr._file.Write(_unk_field32_4);
            fr._file.Write(_unk_field32_5);
            fr._file.Write(_unk_field8_1);
            fr._file.Write(_id3);
            fr._file.Write(_unk_field64_1);
            fr._file.Write(_unk_field64_2);
            fr._file.Write(_unk_field64_3);
            fr._file.Write(_time_length);
            fr._file.Write(_unk_field32_6);
            fr._file.Write(_unk_field64_4);
            fr._file.Write(_unk_field16_1);
            fr._file.Write(_parent);
            fr._file.Write(_unk_field64_5);
            fr._file.Write(_unk_field8_2);
            fr._file.Write(_unk_field32_7);
            fr._file.Write(_unk_field64_6);
            fr._file.Write(_unk_field64_7);
            fr._file.Write(_unk_field16_2);
            fr._file.Write(_unk_field8_3);
            fr._file.Write(_unk_field32_8);

            byte[] result = ms.ToArray();
            fr._file.Close();

            return result;
        }

        #endregion Methods
    }

    public class SBMusicTrackObject
    {
        #region Fields

        public uint _id1 = 0;
        public uint _id2 = 0;
        public uint _id3 = 0;
        public double _time_length = 0;
        public byte[] _unk_data = null;
        public uint _unk_field32_1 = 0;
        public uint _unk_field32_2 = 0;
        public uint _unk_field32_3 = 0;
        public uint _unk_field32_4 = 0;
        public uint _unk_field32_5 = 0;
        public ulong _unk_field64_1 = 0;
        public ulong _unk_field64_2 = 0;
        public ulong _unk_field64_3 = 0;
        public byte _unk_field8_1 = 0;

        #endregion Fields

        #region Constructors

        public SBMusicTrackObject(FileRead fr = null, long curPos = 0, uint length = 0)
        {
            if (fr != null)
            {
                _unk_field32_1 = fr.read_uint32();
                _unk_field32_2 = fr.read_uint32();
                _unk_field32_3 = fr.read_uint32();
                _id1 = fr.read_uint32();

                if (_id1 > 0)
                {
                    _id2 = fr.read_uint32();
                    _unk_field32_4 = fr.read_uint32();
                    _unk_field32_5 = fr.read_uint32();
                    _unk_field8_1 = fr.read_one_byte();
                    _id3 = fr.read_uint32();
                    _unk_field64_1 = fr.read_uint64();
                    _unk_field64_2 = fr.read_uint64();
                    _unk_field64_3 = fr.read_uint64();
                    _time_length = fr.read_double();
                }

                uint remaining = (length - (uint)(fr.getPosition() - curPos));
                if (remaining > 0)
                    _unk_data = fr._file.ReadBytes((int)remaining);
            }
        }

        #endregion Constructors

        #region Methods

        public byte[] getData()
        {
            var ms = new MemoryStream();
            FileWrite fr = new FileWrite(ms);

            fr._file.Write(_unk_field32_1);
            fr._file.Write(_unk_field32_2);
            fr._file.Write(_unk_field32_3);
            fr._file.Write(_id1);

            if (_id1 > 0)
            {
                fr._file.Write(_id2);
                fr._file.Write(_unk_field32_4);
                fr._file.Write(_unk_field32_5);
                fr._file.Write(_unk_field8_1);
                fr._file.Write(_id3);
                fr._file.Write(_unk_field64_1);
                fr._file.Write(_unk_field64_2);
                fr._file.Write(_unk_field64_3);
                fr._file.Write(_time_length);
            }
            if (_unk_data != null)
                fr._file.Write(_unk_data);

            byte[] result = ms.ToArray();
            fr._file.Close();

            return result;
        }

        #endregion Methods
    }

    public class SBObject
    {
        #region Fields

        public const byte TYPE_EVENT = 0x04;
        public const byte TYPE_EVENT_ACTION = 0x03;
        public const byte TYPE_MUSIC_PLAYLIST = 0x0D;
        public const byte TYPE_MUSIC_SEGMENT = 0x0A;
        public const byte TYPE_MUSIC_SWITCH = 0x0C;
        public const byte TYPE_MUSIC_TRACK = 0x0B;
        public const byte TYPE_SOUND = 0x02;
        public string _current_obj = "";
        public uint _id = 0;
        public bool _isSet = true;
        public uint _length = 0;
        public byte[] _obj_bytes = null;
        public SBMusicPlaylistObject _obj_mpo;
        public SBMusicSegmentObject _obj_mso;
        public SBMusicTrackObject _obj_mto;
        public SBMusicTrackCustomObject _obj_mto_custom;
        public SBSoundObject _obj_so;
        public byte _type = 0;

        #endregion Fields

        #region Constructors

        public SBObject(FileRead fr = null)
        {
            if (fr != null)
            {
                _type = fr.read_one_byte();
                _length = fr.read_uint32();
                long curPos = fr.getPosition();
                _id = fr.read_uint32();

                if (_type == TYPE_SOUND)
                {
                    _obj_so = new SBSoundObject(fr, curPos, _length);
                    _current_obj = "SoundObject";
                }
                else if (_type == TYPE_MUSIC_SEGMENT)
                {
                    _obj_mso = new SBMusicSegmentObject(fr, curPos, _length);
                    _current_obj = "MusicSegment";
                }
                else if (_type == TYPE_MUSIC_TRACK)
                {
                    _obj_mto = new SBMusicTrackObject(fr, curPos, _length);
                    _current_obj = "MusicTrack";
                }
                else if (_type == TYPE_MUSIC_PLAYLIST)
                {
                    _obj_mpo = new SBMusicPlaylistObject(fr, curPos, _length);
                    _current_obj = "MusicPlaylist";
                }
                else
                {
                    _obj_bytes = fr._file.ReadBytes((int)(_length - 4));
                    _current_obj = "String";
                }

                if (fr.getPosition() - curPos != _length)
                {
                    Console.WriteLine("SBOjbect : Invalid Object");
                    _isSet = false;
                    return;
                }
            }
        }

        #endregion Constructors

        #region Methods

        public void calculateLength()
        {
            if (_current_obj == "SoundObject")
            {
                _length = 4 + (uint)_obj_so.getData().Length;
            }
            else if (_current_obj == "MusicSegment")
            {
                _length = 4 + (uint)_obj_mso.getData().Length;
            }
            else if (_current_obj == "MusicTrack")
            {
                _length = 4 + (uint)_obj_mto.getData().Length;
            }
            else if (_current_obj == "MusicTrackCustom")
            {
                _length = 4 + (uint)_obj_mto_custom.getData().Length;
            }
            else if (_current_obj == "MusicPlaylist")
            {
                _length = 4 + (uint)_obj_mpo.getData().Length;
            }
            else if (_current_obj == "String")
            {
                _length = 4 + (uint)_obj_bytes.Length;
            }
        }

        public byte[] getData()
        {
            if (_current_obj == "SoundObject")
            {
                return _obj_so.getData();
            }
            else if (_current_obj == "MusicSegment")
            {
                return _obj_mso.getData();
            }
            else if (_current_obj == "MusicTrack")
            {
                return _obj_mto.getData();
            }
            else if (_current_obj == "MusicTrackCustom")
            {
                return _obj_mto_custom.getData();
            }
            else if (_current_obj == "MusicPlaylist")
            {
                return _obj_mpo.getData();
            }
            else if (_current_obj == "String")
            {
                return _obj_bytes;
            }
            return null;
        }

        #endregion Methods
    }

    // get_new_id, read_ids
    public class SBObjects
    {
        #region Fields

        public const string HEAD = "HIRC";

        public string _head = HEAD;
        public List<uint> _ids = new List<uint>();
        public bool _isSet = true;
        public uint _length = 0;
        public List<SBObject> _objects = new List<SBObject>();
        public uint _quantity = 0;

        #endregion Fields

        #region Constructors

        public SBObjects(FileRead fr = null)
        {
            if (fr != null)
            {
                _head = fr.read_header();
                if (_head != HEAD)
                {
                    Console.WriteLine("SBObjects: Invalid header.");
                    _isSet = false;
                    return;
                }

                _length = fr.read_uint32();
                _quantity = fr.read_uint32();
                for (int i = 0; i < _quantity; i++)
                {
                    _objects.Add(new SBObject(fr));
                }
            }
        }

        #endregion Constructors

        #region Methods

        public void calculate_length()
        {
            _quantity = (uint)_objects.Count;
            _length = 4;

            foreach (SBObject obj in _objects)
            {
                _length += (5 + obj._length);
            }
        }

        public uint get_new_id()
        {
            // later
            int nid = -1;
            RandomGen rnd = new RandomGen();

            while (nid == -1)
            {
                nid = (int)rnd.uint32();
                if (_ids.Contains((uint)nid))
                {
                    nid = -1;
                    break;
                }
                foreach (var obj in _objects)
                {
                    if (obj._id == nid)
                    {
                        nid = -1;
                        break;
                    }
                }
            }
            return (uint)nid;
        }

        public void read_ids()
        {
            // later
            FileRead fr = new FileRead("objectids.db");
        }

        #endregion Methods
    }

    public class SBObjectType
    {
        #region Methods

        public string getData()
        {
            return "";
        }

        public int getLength()
        {
            return getData().Length;
        }

        #endregion Methods
    }

    public class SBSoundObject
    {
        #region Fields

        public const uint SOUND_EMBEDED = 0x00;
        public const uint SOUND_PREFETCHED = 0x02;
        public const uint SOUND_STREAMED = 0x01;
        public const uint SOUND_TYPE_SFX = 0x00;
        public const uint SOUND_TYPE_VOICE = 0x01;

        public uint _audio_id = 0;
        public uint _include_type = 0;
        public bool _isSet = true;
        public uint _offset = 0;
        public uint _size = 0;
        public byte[] _sound_structure = null;
        public byte _sound_type = 0;
        public uint _source_id = 0;
        public uint _unk_field32_1 = 0;

        #endregion Fields

        #region Constructors

        public SBSoundObject(FileRead fr = null, long curPos = 0, uint length = 0)
        {
            if (fr != null)
            {
                _unk_field32_1 = fr.read_uint32();
                _include_type = fr.read_uint32();

                if (_include_type != SOUND_EMBEDED && _include_type != SOUND_STREAMED && _include_type != SOUND_PREFETCHED)
                {
                    Console.WriteLine("SBSoundObject: Invalid include type.");
                    _isSet = false;
                    return;
                }

                _audio_id = fr.read_uint32();
                _source_id = fr.read_uint32();

                if (_include_type == SOUND_EMBEDED)
                {
                    _offset = fr.read_uint32();
                    _size = fr.read_uint32();
                }

                _sound_type = fr.read_one_byte();

                if (_sound_type != SOUND_TYPE_SFX && _sound_type != SOUND_TYPE_VOICE)
                {
                    Console.WriteLine("SBSoundObject: Invalid sound type.");
                    _isSet = false;
                    return;
                }
                _sound_structure = fr._file.ReadBytes((int)(length - (uint)(fr.getPosition() - curPos)));
            }
        }

        #endregion Constructors

        #region Methods

        public byte[] getData()
        {
            var ms = new MemoryStream();
            FileWrite fr = new FileWrite(ms);

            fr._file.Write(_unk_field32_1);
            fr._file.Write((UInt32)_include_type);
            fr._file.Write((UInt32)_audio_id);
            fr._file.Write((UInt32)_source_id);

            if (_include_type == SOUND_EMBEDED)
            {
                fr._file.Write((UInt32)_offset);
                fr._file.Write((UInt32)_size);
            }
            fr._file.Write(_sound_type);
            fr._file.Write(_sound_structure);

            byte[] result = ms.ToArray();
            fr._file.Close();

            return result;
        }

        #endregion Methods
    }

    public class SBSoundTypeID
    {
        #region Fields

        public const string HEAD = "STID";
        public string _head = HEAD;
        public bool _isSet = true;
        public uint _length = 0;
        public uint _quantity = 0;
        public byte[] _remaining = null;
        public uint _unk_field32_1 = 1;

        #endregion Fields

        #region Constructors

        public SBSoundTypeID(FileRead fr = null)
        {
            if (fr != null)
            {
                _head = fr.read_header();
                if (_head != HEAD)
                {
                    Console.WriteLine("SBSoundTypeID: Invalid header.");
                    _isSet = false;
                    return;
                }
                _length = fr.read_uint32();
                _unk_field32_1 = fr.read_uint32();
                _quantity = fr.read_uint32();
                _remaining = fr._file.ReadBytes((int)(_length - 8));
            }
        }

        #endregion Constructors
    }
}
