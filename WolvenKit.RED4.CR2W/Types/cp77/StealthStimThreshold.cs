using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StealthStimThreshold : AIbehaviorconditionScript
	{
		private CInt32 _stealthThresholdNumber;

		[Ordinal(0)] 
		[RED("stealthThresholdNumber")] 
		public CInt32 StealthThresholdNumber
		{
			get
			{
				if (_stealthThresholdNumber == null)
				{
					_stealthThresholdNumber = (CInt32) CR2WTypeManager.Create("Int32", "stealthThresholdNumber", cr2w, this);
				}
				return _stealthThresholdNumber;
			}
			set
			{
				if (_stealthThresholdNumber == value)
				{
					return;
				}
				_stealthThresholdNumber = value;
				PropertySet(this);
			}
		}

		public StealthStimThreshold(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
