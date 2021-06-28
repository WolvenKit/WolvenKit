using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIApproachingAreaResponseEvent : redEvent
	{
		private wCHandle<entEntity> _sender;
		private wCHandle<gameStaticAreaShapeComponent> _areaComponent;
		private CBool _isPassingThrough;

		[Ordinal(0)] 
		[RED("sender")] 
		public wCHandle<entEntity> Sender
		{
			get => GetProperty(ref _sender);
			set => SetProperty(ref _sender, value);
		}

		[Ordinal(1)] 
		[RED("areaComponent")] 
		public wCHandle<gameStaticAreaShapeComponent> AreaComponent
		{
			get => GetProperty(ref _areaComponent);
			set => SetProperty(ref _areaComponent, value);
		}

		[Ordinal(2)] 
		[RED("isPassingThrough")] 
		public CBool IsPassingThrough
		{
			get => GetProperty(ref _isPassingThrough);
			set => SetProperty(ref _isPassingThrough, value);
		}

		public AIApproachingAreaResponseEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
