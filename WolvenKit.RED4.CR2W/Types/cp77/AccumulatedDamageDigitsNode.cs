using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AccumulatedDamageDigitsNode : CVariable
	{
		private CBool _used;
		private entEntityID _entityID;
		private wCHandle<AccumulatedDamageDigitLogicController> _controller;
		private CBool _isDamageOverTime;

		[Ordinal(0)] 
		[RED("used")] 
		public CBool Used
		{
			get => GetProperty(ref _used);
			set => SetProperty(ref _used, value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(2)] 
		[RED("controller")] 
		public wCHandle<AccumulatedDamageDigitLogicController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(3)] 
		[RED("isDamageOverTime")] 
		public CBool IsDamageOverTime
		{
			get => GetProperty(ref _isDamageOverTime);
			set => SetProperty(ref _isDamageOverTime, value);
		}

		public AccumulatedDamageDigitsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
