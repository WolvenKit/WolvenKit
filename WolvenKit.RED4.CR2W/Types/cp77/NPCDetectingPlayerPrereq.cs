using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCDetectingPlayerPrereq : gameIScriptablePrereq
	{
		private CFloat _threshold;

		[Ordinal(0)] 
		[RED("threshold")] 
		public CFloat Threshold
		{
			get
			{
				if (_threshold == null)
				{
					_threshold = (CFloat) CR2WTypeManager.Create("Float", "threshold", cr2w, this);
				}
				return _threshold;
			}
			set
			{
				if (_threshold == value)
				{
					return;
				}
				_threshold = value;
				PropertySet(this);
			}
		}

		public NPCDetectingPlayerPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
