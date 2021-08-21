using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPermanentLayerDefinitionCollection : CVariable
	{
		private inkLoadingLayerDefinition _loadingLayer;
		private inkWatermarksLayerDefinition _watermarksLayer;
		private inkSystemNotificationsLayerDefinition _sysNotificationsLayer;
		private inkWaitingSignLayerDefinition _waitingSignLayerDefinition;

		[Ordinal(0)] 
		[RED("loadingLayer")] 
		public inkLoadingLayerDefinition LoadingLayer
		{
			get => GetProperty(ref _loadingLayer);
			set => SetProperty(ref _loadingLayer, value);
		}

		[Ordinal(1)] 
		[RED("watermarksLayer")] 
		public inkWatermarksLayerDefinition WatermarksLayer
		{
			get => GetProperty(ref _watermarksLayer);
			set => SetProperty(ref _watermarksLayer, value);
		}

		[Ordinal(2)] 
		[RED("sysNotificationsLayer")] 
		public inkSystemNotificationsLayerDefinition SysNotificationsLayer
		{
			get => GetProperty(ref _sysNotificationsLayer);
			set => SetProperty(ref _sysNotificationsLayer, value);
		}

		[Ordinal(3)] 
		[RED("waitingSignLayerDefinition")] 
		public inkWaitingSignLayerDefinition WaitingSignLayerDefinition
		{
			get => GetProperty(ref _waitingSignLayerDefinition);
			set => SetProperty(ref _waitingSignLayerDefinition, value);
		}

		public inkPermanentLayerDefinitionCollection(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
