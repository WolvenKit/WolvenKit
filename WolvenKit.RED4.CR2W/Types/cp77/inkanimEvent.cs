using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimEvent : IScriptable
	{
		private CFloat _startTime;

		[Ordinal(0)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get
			{
				if (_startTime == null)
				{
					_startTime = (CFloat) CR2WTypeManager.Create("Float", "startTime", cr2w, this);
				}
				return _startTime;
			}
			set
			{
				if (_startTime == value)
				{
					return;
				}
				_startTime = value;
				PropertySet(this);
			}
		}

		public inkanimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
