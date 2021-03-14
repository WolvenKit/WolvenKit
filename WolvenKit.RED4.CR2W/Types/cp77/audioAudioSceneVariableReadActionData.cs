using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneVariableReadActionData : CVariable
	{
		private CName _name;
		private CEnum<audioNumberComparer> _comparer;
		private CInt32 _value;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("comparer")] 
		public CEnum<audioNumberComparer> Comparer
		{
			get
			{
				if (_comparer == null)
				{
					_comparer = (CEnum<audioNumberComparer>) CR2WTypeManager.Create("audioNumberComparer", "comparer", cr2w, this);
				}
				return _comparer;
			}
			set
			{
				if (_comparer == value)
				{
					return;
				}
				_comparer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CInt32) CR2WTypeManager.Create("Int32", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public audioAudioSceneVariableReadActionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
