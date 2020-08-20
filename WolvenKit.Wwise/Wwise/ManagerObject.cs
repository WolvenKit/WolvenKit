using System.Collections.Generic;

namespace WolvenKit.Wwise.Wwise
{
    public class ManagerObject
    {
    }

    
    public class ManagerObject_StateGroup_CustomTransition
    {
        public uint _from_id = 0;
        public uint _to_id = 0;
        public uint _trans_time = 0;

        public ManagerObject_StateGroup_CustomTransition(FileRead fr = null)
        {
            if (fr != null)
            {
                _from_id = fr.read_uint32();
                _to_id = fr.read_uint32();
                _trans_time = fr.read_uint32();
            }
        }
    }

    
    public class ManagerObject_StateGroup
    {
        public uint _id = 0;
        public uint _default_trans = 0;
        public uint _custom_trans_count = 0;
        public List<ManagerObject_StateGroup_CustomTransition> _custom_trans = new List<ManagerObject_StateGroup_CustomTransition>();

        public ManagerObject_StateGroup(FileRead fr = null)
        {
            if (fr != null)
            {
                _id = fr.read_uint32();
                _default_trans = fr.read_uint32();

                _custom_trans_count = fr.read_uint32();
                for (int i = 0; i < _custom_trans_count; i++)
                {
                    _custom_trans.Add(new ManagerObject_StateGroup_CustomTransition(fr));
                }
            }
        }

    }

    
    public class ManagerObject_SwitchGroup
    {
        public uint _id = 0;
        public uint _game_parameter_id = 0;
        public uint _points_count = 0;
        public List<ManagerObject_SwitchGroup_Point> _points = new List<ManagerObject_SwitchGroup_Point>();

        public ManagerObject_SwitchGroup(FileRead fr = null)
        {
            if (fr == null)
            {
                _id = fr.read_uint32();
                _game_parameter_id = fr.read_uint32();

                _points_count = fr.read_uint32();
                for (int i = 0; i < _points_count; i++)
                {
                    _points.Add(new ManagerObject_SwitchGroup_Point(fr));
                }
            }
        }

    }

    
    public class ManagerObject_SwitchGroup_Point
    {
        public float _value = 0;
        public uint _switch_id = 0;
        public uint _shape_curve = 0x09;

        public ManagerObject_SwitchGroup_Point(FileRead fr = null)
        {
            if (fr != null)
            {
                _value = fr.read_float();
                _switch_id = fr.read_uint32();
                _shape_curve = fr.read_uint32();
            }
        }
    }

    
    public class ManagerObject_GameParameter
    {
        public uint _id = 0;
        public float _default_value = 0;
        public ManagerObject_GameParameter(FileRead fr = null)
        {
            if (fr != null)
            {
                _id = fr.read_uint32();
                _default_value = fr.read_float();
            }
        }
    }

}
