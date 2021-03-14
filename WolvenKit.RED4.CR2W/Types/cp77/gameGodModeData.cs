using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGodModeData : CVariable
	{
		private CEnum<gameGodModeType> _type;
		private CName _source;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameGodModeType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameGodModeType>) CR2WTypeManager.Create("gameGodModeType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get
			{
				if (_source == null)
				{
					_source = (CName) CR2WTypeManager.Create("CName", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		public gameGodModeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
