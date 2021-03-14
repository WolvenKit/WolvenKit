using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TemporalPrereq : gameIScriptablePrereq
	{
		private CFloat _totalDuration;

		[Ordinal(0)] 
		[RED("totalDuration")] 
		public CFloat TotalDuration
		{
			get
			{
				if (_totalDuration == null)
				{
					_totalDuration = (CFloat) CR2WTypeManager.Create("Float", "totalDuration", cr2w, this);
				}
				return _totalDuration;
			}
			set
			{
				if (_totalDuration == value)
				{
					return;
				}
				_totalDuration = value;
				PropertySet(this);
			}
		}

		public TemporalPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
