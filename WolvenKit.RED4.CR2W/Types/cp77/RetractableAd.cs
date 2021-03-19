using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RetractableAd : BaseAnimatedDevice
	{
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnection;
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;
		private CHandle<entIComponent> _advUiComponent;
		private CBool _isPartOfTheTrap;

		[Ordinal(98)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get => GetProperty(ref _offMeshConnection);
			set => SetProperty(ref _offMeshConnection, value);
		}

		[Ordinal(99)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetProperty(ref _areaComponent);
			set => SetProperty(ref _areaComponent, value);
		}

		[Ordinal(100)] 
		[RED("advUiComponent")] 
		public CHandle<entIComponent> AdvUiComponent
		{
			get => GetProperty(ref _advUiComponent);
			set => SetProperty(ref _advUiComponent, value);
		}

		[Ordinal(101)] 
		[RED("isPartOfTheTrap")] 
		public CBool IsPartOfTheTrap
		{
			get => GetProperty(ref _isPartOfTheTrap);
			set => SetProperty(ref _isPartOfTheTrap, value);
		}

		public RetractableAd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
