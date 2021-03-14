using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WoundedTriggeredPrereq : gameIScriptablePrereq
	{
		private CUInt32 _currValue;

		[Ordinal(0)] 
		[RED("currValue")] 
		public CUInt32 CurrValue
		{
			get
			{
				if (_currValue == null)
				{
					_currValue = (CUInt32) CR2WTypeManager.Create("Uint32", "currValue", cr2w, this);
				}
				return _currValue;
			}
			set
			{
				if (_currValue == value)
				{
					return;
				}
				_currValue = value;
				PropertySet(this);
			}
		}

		public WoundedTriggeredPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
