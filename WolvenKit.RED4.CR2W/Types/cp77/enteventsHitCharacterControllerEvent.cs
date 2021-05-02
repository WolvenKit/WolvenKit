using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class enteventsHitCharacterControllerEvent : redEvent
	{
		private wCHandle<entEntity> _entity;
		private wCHandle<entIComponent> _component;

		[Ordinal(0)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(1)] 
		[RED("component")] 
		public wCHandle<entIComponent> Component
		{
			get => GetProperty(ref _component);
			set => SetProperty(ref _component, value);
		}

		public enteventsHitCharacterControllerEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
