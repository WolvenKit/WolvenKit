using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakspotHealthChangeListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<gameObject> _self;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;

		[Ordinal(0)] 
		[RED("self")] 
		public wCHandle<gameObject> Self
		{
			get => GetProperty(ref _self);
			set => SetProperty(ref _self, value);
		}

		[Ordinal(1)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(2)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetProperty(ref _statPoolSystem);
			set => SetProperty(ref _statPoolSystem, value);
		}

		public WeakspotHealthChangeListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
