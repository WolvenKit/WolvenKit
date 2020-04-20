using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WolvenKit.Wwise.Wwise
{

    
    public class SoundStructure_Effect
    {
        public byte _index = 0;
        public uint _id = 0;
        public ushort _unk_field16_1 = 0;

        public SoundStructure_Effect(FileRead fr = null)
        {
            if (fr != null)
            {
                _index = fr.read_one_byte();
                _id = fr.read_uint32();
                _unk_field16_1 = fr.read_uint16();
            }
        }
    }

    // need to check one value
    // 
    public class SoundStructure_Additional
    {
        public byte _type = 0;
        public float _value_f = 0;
        public uint _value_u = 0;

        public SoundStructure_Additional(FileRead fr = null)
        {
            if (fr != null)
            {
                _type = fr.read_one_byte();
            }
        }
    }

    
    public class SoundStructure_StateGroup
    {
        public uint _id = 0;
        public byte _change_occurs = 0;
        public ushort _different;
        public List<uint> _ids = new List<uint>();
        public List<uint> _ids_object_contain = new List<uint>();

        public SoundStructure_StateGroup(FileRead fr = null)
        {
            if (fr != null)
            {
                _id = fr.read_uint32();
                _change_occurs = fr.read_one_byte();
                _different = fr.read_uint16();
                for (int i = 0; i < _different; i++)
                {
                    _ids.Add(fr.read_uint32());
                    _ids_object_contain.Add(fr.read_uint32());
                }
            }
        }
    }

    
    public class SoundStructure_RTPC
    {
        public uint _x_axis_id = 0;
        public uint _y_axis_type = 0;
        public uint _unk_field32_1 = 0;
        public byte _unk_field8_1 = 0;
        public byte _unk_field8_2 = 0;
        public byte _points_count = 0;
        public List<float> _x_coordinates = new List<float>();
        public List<float> _y_coordinates = new List<float>();
        public List<uint> _curve_shape = new List<uint>();

        public SoundStructure_RTPC(FileRead fr = null)
        {
            if (fr != null)
            {
                _x_axis_id = fr.read_uint32();
                _y_axis_type = fr.read_uint32();
                _unk_field32_1 = fr.read_uint32();
                _unk_field8_1 = fr.read_one_byte();
                _points_count = fr.read_one_byte();
                _unk_field8_2 = fr.read_one_byte();

                for (int i = 0; i < _points_count; i++)
                {
                    _x_coordinates.Add(fr.read_float());
                    _y_coordinates.Add(fr.read_float());
                    _curve_shape.Add(fr.read_uint32());
                }
            }
        }

    }

    
    public class SoundStructure
    {
        public bool _effects_override = false;
        public byte _effects_count = 0;
        public List<SoundStructure_Effect> _effects = new List<SoundStructure_Effect>();
        public byte _effects_bitmask = 0;
        public uint _output_bus_id = 0;
        public uint _parent_id = 0;
        public bool _override_playback_priority = false;
        public bool _offset_priority = false;
        public byte _additional_parameters_count = 0;
        public List<SoundStructure_Additional> _additional_parameters = new List<SoundStructure_Additional>();
        public byte _unk_field8_1 = 0;
        public bool _has_positioning = false;
        public byte _positioning_type = 0;
        public bool _enable_panner = false;
        public uint _position_source = 0;
        public uint _attenuation_id = 0;
        public bool _enable_spatialization = false;
        public uint _play_type = 0;
        public bool _do_loop = false;
        public uint _transition_time = 0;
        public bool _follow_listener_orientation = false;
        public bool _update_at_each_frame = false;
        public ushort _unk_field16_1 = 0;
        public uint _unk_field32_1 = 0;
        public uint _unk_field32_2 = 0;

        public bool _override_game_auxiliary_sends = false;
        public bool _use_game_auxiliary_sends = false;
        public bool _override_user_auxiliary_sends = false;
        public bool _user_auxiliary_sends_exists = false;

        public uint _auxiliary_bus_id0 = 0;
        public uint _auxiliary_bus_id1 = 0;
        public uint _auxiliary_bus_id2 = 0;
        public uint _auxiliary_bus_id3 = 0;
        public bool _unk_field8_2 = false;
        public byte _priority_equal = 0;
        public byte _limit_reached = 0;
        public ushort _limit_sound_instances = 0;

        public byte _how_to_limit_sound_instances = 0;
        public byte _virtual_voice_behavior = 0;
        public bool _override_playback_limit = false;
        public bool _override_virtual_voice = false;
        public uint _state_groups_count = 0;
        public List<SoundStructure_StateGroup> _state_groups = new List<SoundStructure_StateGroup>();
        public ushort _rtpc_count = 0;
        public List<SoundStructure_RTPC> _rtpcs = new List<SoundStructure_RTPC>();
        public uint _unk_field32_3 = 0;
        public string _unk_data = "";

        public SoundStructure(FileRead fr = null)
        {
            if (fr != null)
            {
                long pos = fr.getPosition();
                _effects_override = fr.read_bool();

                _effects_count = fr.read_one_byte();
                if (_effects_count > 0)
                {
                    _effects_bitmask = fr.read_one_byte();
                    for (int i = 0; i < _effects_count; i++)
                    {
                        _effects.Add(new SoundStructure_Effect(fr));
                    }
                }

                _output_bus_id = fr.read_uint32();
                _parent_id = fr.read_uint32();
                _override_playback_priority = fr.read_bool();
                _offset_priority = fr.read_bool();

                _additional_parameters_count = fr.read_one_byte();
                if (_additional_parameters_count > 0)
                {
                    for (int i = 0; i < _additional_parameters_count; i++)
                    {
                        _additional_parameters.Add(new SoundStructure_Additional(fr));
                    }
                    foreach (SoundStructure_Additional sa in _additional_parameters)
                    {
                        if(sa._type == 0x07)
                        {
                            sa._value_u = fr.read_uint32();
                        }
                        else
                        {
                            sa._value_f = fr.read_float();
                        }
                    }
                }

                _unk_field8_1 = fr.read_one_byte();

                _has_positioning = fr.read_bool();
                if (_has_positioning)
                {
                    _positioning_type = fr.read_one_byte();
                    if (_positioning_type == 0x2D)
                    {
                        _enable_panner = fr.read_bool();
                    }
                    else if (_positioning_type == 0x3D)
                    {
                        _position_source = fr.read_uint32();
                        _attenuation_id = fr.read_uint32();
                        _enable_spatialization = fr.read_bool();

                        if (_position_source == 0x02)
                        {
                            _play_type = fr.read_uint32();
                            _do_loop = fr.read_bool();
                            _transition_time = fr.read_uint32();
                            _follow_listener_orientation = fr.read_bool();
                        }
                        else if (_position_source == 0x03)
                        {
                            _update_at_each_frame = fr.read_bool();
                        }
                    }
                    else if (_positioning_type == 0x01)
                    {
                        _unk_field16_1 = fr.read_uint16();
                    }
                    else
                    {
                        _unk_field32_1 = fr.read_uint32();
                        _unk_field32_2 = fr.read_uint32();
                    }
                }

                _override_game_auxiliary_sends = fr.read_bool();
                _use_game_auxiliary_sends = fr.read_bool();
                _override_user_auxiliary_sends = fr.read_bool();
                _user_auxiliary_sends_exists = fr.read_bool();

                if (_user_auxiliary_sends_exists)
                {
                    _auxiliary_bus_id0 = fr.read_uint32();
                    _auxiliary_bus_id1 = fr.read_uint32();
                    _auxiliary_bus_id2 = fr.read_uint32();
                    _auxiliary_bus_id3 = fr.read_uint32();
                }

                _unk_field8_2 = fr.read_bool();
                if (_unk_field8_2)
                {
                    _priority_equal = fr.read_one_byte();
                    _limit_reached = fr.read_one_byte();
                    _limit_sound_instances = fr.read_uint16();
                }

                _how_to_limit_sound_instances = fr.read_one_byte();
                _virtual_voice_behavior = fr.read_one_byte();
                _override_playback_limit = fr.read_bool();
                _override_virtual_voice = fr.read_bool();

                _state_groups_count = fr.read_uint32();
                if (_state_groups_count > 0)
                {
                    for (int i = 0; i < _state_groups_count; i++)
                    {
                        _state_groups.Add(new SoundStructure_StateGroup(fr));
                    }
                }

                _rtpc_count = fr.read_uint16();
                if (_rtpc_count > 0)
                {
                    for (int i = 0; i < _rtpc_count; i++)
                    {
                        _rtpcs.Add(new SoundStructure_RTPC(fr));
                    }
                }

                _unk_field32_3 = fr.read_uint32();
                if (_unk_field32_3 > 0)
                {
                    _unk_data = fr.read_uchar(0x3F);
                }
                else
                {
                    _unk_data = "";
                }
            }
        }

        public string getData()
        {
            var ms = new MemoryStream();
            FileWrite fr = new FileWrite(ms);

            fr._file.Write(_effects_override);
            fr._file.Write(_effects_count);

            if (_effects_count > 0)
            {
                fr._file.Write(_effects_bitmask);
                foreach (SoundStructure_Effect se in _effects)
                {
                    fr._file.Write(se._index);
                    fr._file.Write(se._id);
                    fr._file.Write(se._unk_field16_1);
                }
            }

            fr._file.Write(_output_bus_id);
            fr._file.Write(_parent_id);
            fr._file.Write(_override_playback_priority);
            fr._file.Write(_offset_priority);
            fr._file.Write(_additional_parameters_count);

            foreach (SoundStructure_Additional sa in _additional_parameters)
            {
                fr._file.Write(sa._type);
            }
            foreach (SoundStructure_Additional sa in _additional_parameters)
            {
                if (sa._type == 0x07)
                {
                    fr._file.Write(sa._value_u);
                }
                else
                {
                    fr._file.Write(sa._value_f);
                }
            }

            fr._file.Write(_unk_field8_1);
            fr._file.Write(_has_positioning);

            if (_has_positioning)
            {
                fr._file.Write(_positioning_type);
                if (_positioning_type == 0x2D)
                {
                    fr._file.Write(_enable_panner);
                }
                else if (_positioning_type == 0x3D)
                {
                    fr._file.Write(_position_source);
                    fr._file.Write(_attenuation_id);
                    fr._file.Write(_enable_spatialization);
                    if (_position_source == 0x02)
                    {
                        fr._file.Write(_play_type);
                        fr._file.Write(_do_loop);
                        fr._file.Write(_transition_time);
                        fr._file.Write(_follow_listener_orientation);
                    }
                    else if (_position_source == 0x03)
                    {
                        fr._file.Write(_update_at_each_frame);
                    }
                }
                else if (_positioning_type == 0x01)
                {
                    fr._file.Write(_unk_field16_1);
                }
                else
                {
                    fr._file.Write(_unk_field32_1);
                    fr._file.Write(_unk_field32_2);
                }
            }

            fr._file.Write(_override_game_auxiliary_sends);
            fr._file.Write(_use_game_auxiliary_sends);
            fr._file.Write(_override_user_auxiliary_sends);
            fr._file.Write(_user_auxiliary_sends_exists);

            if (_user_auxiliary_sends_exists)
            {
                fr._file.Write(_auxiliary_bus_id0);
                fr._file.Write(_auxiliary_bus_id1);
                fr._file.Write(_auxiliary_bus_id2);
                fr._file.Write(_auxiliary_bus_id3);
            }

            fr._file.Write(_unk_field8_2);

            if (_unk_field8_2)
            {
                fr._file.Write(_priority_equal);
                fr._file.Write(_limit_reached);
                fr._file.Write(_limit_sound_instances);
            }

            fr._file.Write(_how_to_limit_sound_instances);
            fr._file.Write(_virtual_voice_behavior);
            fr._file.Write(_override_playback_limit);
            fr._file.Write(_override_virtual_voice);

            fr._file.Write(_state_groups_count);
            foreach (SoundStructure_StateGroup ss in _state_groups)
            {
                fr._file.Write(ss._id);
                fr._file.Write(ss._change_occurs);
                fr._file.Write(ss._different);

                for (int i = 0; i < ss._different; i++)
                {
                    fr._file.Write(ss._ids[i]);
                    fr._file.Write(ss._ids_object_contain[i]);
                }
            }

            fr._file.Write(_rtpc_count);
            foreach (SoundStructure_RTPC sr in _rtpcs)
            {
                fr._file.Write(sr._x_axis_id);
                fr._file.Write(sr._y_axis_type);
                fr._file.Write(sr._unk_field32_1);
                fr._file.Write(sr._unk_field8_1);
                fr._file.Write(sr._points_count);
                fr._file.Write(sr._unk_field8_2);

                for (int i = 0; i < sr._points_count; i++)
                {
                    fr._file.Write(sr._x_coordinates[i]);
                    fr._file.Write(sr._y_coordinates[i]);
                    fr._file.Write(sr._curve_shape[i]);
                }

            }

            fr._file.Write(_unk_field32_3);

            if (_unk_data != "")
                fr._file.Write(_unk_data);

            string result = new String(ms.ToArray().ToList().Select(x => (char)x).ToArray());
            fr._file.Close();

            return result;
        }

        public int getLength()
        {
            return getData().Length;
        }
    }

}
