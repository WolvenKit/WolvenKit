using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRenderToTextureFeatures : RedBaseClass
	{
		private CBool _renderDecals;
		private CBool _renderParticles;
		private CBool _renderForwardNoTXAA;
		private CBool _antiAliasing;
		private CBool _contactShadows;
		private CBool _localShadows;
		private CBool _allowOcclusionCulling;

		[Ordinal(0)] 
		[RED("renderDecals")] 
		public CBool RenderDecals
		{
			get => GetProperty(ref _renderDecals);
			set => SetProperty(ref _renderDecals, value);
		}

		[Ordinal(1)] 
		[RED("renderParticles")] 
		public CBool RenderParticles
		{
			get => GetProperty(ref _renderParticles);
			set => SetProperty(ref _renderParticles, value);
		}

		[Ordinal(2)] 
		[RED("renderForwardNoTXAA")] 
		public CBool RenderForwardNoTXAA
		{
			get => GetProperty(ref _renderForwardNoTXAA);
			set => SetProperty(ref _renderForwardNoTXAA, value);
		}

		[Ordinal(3)] 
		[RED("antiAliasing")] 
		public CBool AntiAliasing
		{
			get => GetProperty(ref _antiAliasing);
			set => SetProperty(ref _antiAliasing, value);
		}

		[Ordinal(4)] 
		[RED("contactShadows")] 
		public CBool ContactShadows
		{
			get => GetProperty(ref _contactShadows);
			set => SetProperty(ref _contactShadows, value);
		}

		[Ordinal(5)] 
		[RED("localShadows")] 
		public CBool LocalShadows
		{
			get => GetProperty(ref _localShadows);
			set => SetProperty(ref _localShadows, value);
		}

		[Ordinal(6)] 
		[RED("allowOcclusionCulling")] 
		public CBool AllowOcclusionCulling
		{
			get => GetProperty(ref _allowOcclusionCulling);
			set => SetProperty(ref _allowOcclusionCulling, value);
		}
	}
}
