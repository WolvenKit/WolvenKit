using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimatedComponent : entISkinableComponent
	{
		private CHandle<entAnimationControlBinding> _controlBinding;
		private CResourceReference<animRig> _rig;
		private CResourceReference<animAnimGraph> _graph;
		private animAnimSetup _animations;
		private redTagList _animTags;
		private CName _audioAltName;
		private CBool _useLongRangeVisibility;
		private CResourceAsyncReference<animFacialSetup> _facialSetup;
		private CBool _calculateAccelerationWs;
		private CArray<entAnimTrackParameter> _animParameters;
		private CInt32 _serverForcedLod;
		private CInt32 _clientForcedLod;
		private CBool _serverForcedVisibility;
		private CBool _clientForcedVisibility;

		[Ordinal(5)] 
		[RED("controlBinding")] 
		public CHandle<entAnimationControlBinding> ControlBinding
		{
			get => GetProperty(ref _controlBinding);
			set => SetProperty(ref _controlBinding, value);
		}

		[Ordinal(6)] 
		[RED("rig")] 
		public CResourceReference<animRig> Rig
		{
			get => GetProperty(ref _rig);
			set => SetProperty(ref _rig, value);
		}

		[Ordinal(7)] 
		[RED("graph")] 
		public CResourceReference<animAnimGraph> Graph
		{
			get => GetProperty(ref _graph);
			set => SetProperty(ref _graph, value);
		}

		[Ordinal(8)] 
		[RED("animations")] 
		public animAnimSetup Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		[Ordinal(9)] 
		[RED("animTags")] 
		public redTagList AnimTags
		{
			get => GetProperty(ref _animTags);
			set => SetProperty(ref _animTags, value);
		}

		[Ordinal(10)] 
		[RED("audioAltName")] 
		public CName AudioAltName
		{
			get => GetProperty(ref _audioAltName);
			set => SetProperty(ref _audioAltName, value);
		}

		[Ordinal(11)] 
		[RED("useLongRangeVisibility")] 
		public CBool UseLongRangeVisibility
		{
			get => GetProperty(ref _useLongRangeVisibility);
			set => SetProperty(ref _useLongRangeVisibility, value);
		}

		[Ordinal(12)] 
		[RED("facialSetup")] 
		public CResourceAsyncReference<animFacialSetup> FacialSetup
		{
			get => GetProperty(ref _facialSetup);
			set => SetProperty(ref _facialSetup, value);
		}

		[Ordinal(13)] 
		[RED("calculateAccelerationWs")] 
		public CBool CalculateAccelerationWs
		{
			get => GetProperty(ref _calculateAccelerationWs);
			set => SetProperty(ref _calculateAccelerationWs, value);
		}

		[Ordinal(14)] 
		[RED("animParameters")] 
		public CArray<entAnimTrackParameter> AnimParameters
		{
			get => GetProperty(ref _animParameters);
			set => SetProperty(ref _animParameters, value);
		}

		[Ordinal(15)] 
		[RED("serverForcedLod")] 
		public CInt32 ServerForcedLod
		{
			get => GetProperty(ref _serverForcedLod);
			set => SetProperty(ref _serverForcedLod, value);
		}

		[Ordinal(16)] 
		[RED("clientForcedLod")] 
		public CInt32 ClientForcedLod
		{
			get => GetProperty(ref _clientForcedLod);
			set => SetProperty(ref _clientForcedLod, value);
		}

		[Ordinal(17)] 
		[RED("serverForcedVisibility")] 
		public CBool ServerForcedVisibility
		{
			get => GetProperty(ref _serverForcedVisibility);
			set => SetProperty(ref _serverForcedVisibility, value);
		}

		[Ordinal(18)] 
		[RED("clientForcedVisibility")] 
		public CBool ClientForcedVisibility
		{
			get => GetProperty(ref _clientForcedVisibility);
			set => SetProperty(ref _clientForcedVisibility, value);
		}

		public entAnimatedComponent()
		{
			_serverForcedLod = -1;
			_clientForcedLod = -1;
		}
	}
}
