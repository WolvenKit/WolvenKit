using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetTier4Params_NodeType : questISceneManagerNodeType
	{
		private NodeRef _objectRef;
		private CFloat _adjustTime;
		private CBool _usePlayerWorkspot;
		private CBool _useEnterAnim;
		private CBool _useExitAnim;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("adjustTime")] 
		public CFloat AdjustTime
		{
			get => GetProperty(ref _adjustTime);
			set => SetProperty(ref _adjustTime, value);
		}

		[Ordinal(2)] 
		[RED("usePlayerWorkspot")] 
		public CBool UsePlayerWorkspot
		{
			get => GetProperty(ref _usePlayerWorkspot);
			set => SetProperty(ref _usePlayerWorkspot, value);
		}

		[Ordinal(3)] 
		[RED("useEnterAnim")] 
		public CBool UseEnterAnim
		{
			get => GetProperty(ref _useEnterAnim);
			set => SetProperty(ref _useEnterAnim, value);
		}

		[Ordinal(4)] 
		[RED("useExitAnim")] 
		public CBool UseExitAnim
		{
			get => GetProperty(ref _useExitAnim);
			set => SetProperty(ref _useExitAnim, value);
		}

		public questSetTier4Params_NodeType()
		{
			_useEnterAnim = true;
			_useExitAnim = true;
		}
	}
}
