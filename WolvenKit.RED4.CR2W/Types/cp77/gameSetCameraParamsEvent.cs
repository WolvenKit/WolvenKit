using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetCameraParamsEvent : redEvent
	{
		private CName _paramsName;

		[Ordinal(0)] 
		[RED("paramsName")] 
		public CName ParamsName
		{
			get
			{
				if (_paramsName == null)
				{
					_paramsName = (CName) CR2WTypeManager.Create("CName", "paramsName", cr2w, this);
				}
				return _paramsName;
			}
			set
			{
				if (_paramsName == value)
				{
					return;
				}
				_paramsName = value;
				PropertySet(this);
			}
		}

		public gameSetCameraParamsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
