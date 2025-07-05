using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimatedComponent : entISkinableComponent
	{
		[Ordinal(5)] 
		[RED("controlBinding")] 
		public CHandle<entAnimationControlBinding> ControlBinding
		{
			get => GetPropertyValue<CHandle<entAnimationControlBinding>>();
			set => SetPropertyValue<CHandle<entAnimationControlBinding>>(value);
		}

		[Ordinal(6)] 
		[RED("rig")] 
		public CResourceReference<animRig> Rig
		{
			get => GetPropertyValue<CResourceReference<animRig>>();
			set => SetPropertyValue<CResourceReference<animRig>>(value);
		}

		[Ordinal(7)] 
		[RED("graph")] 
		public CResourceReference<animAnimGraph> Graph
		{
			get => GetPropertyValue<CResourceReference<animAnimGraph>>();
			set => SetPropertyValue<CResourceReference<animAnimGraph>>(value);
		}

		[Ordinal(8)] 
		[RED("animations")] 
		public animAnimSetup Animations
		{
			get => GetPropertyValue<animAnimSetup>();
			set => SetPropertyValue<animAnimSetup>(value);
		}

		[Ordinal(9)] 
		[RED("animTags")] 
		public redTagList AnimTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(10)] 
		[RED("audioAltName")] 
		public CName AudioAltName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("useLongRangeVisibility")] 
		public CBool UseLongRangeVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("facialSetup")] 
		public CResourceAsyncReference<animFacialSetup> FacialSetup
		{
			get => GetPropertyValue<CResourceAsyncReference<animFacialSetup>>();
			set => SetPropertyValue<CResourceAsyncReference<animFacialSetup>>(value);
		}

		[Ordinal(13)] 
		[RED("calculateAccelerationWs")] 
		public CBool CalculateAccelerationWs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("animParameters")] 
		public CArray<entAnimTrackParameter> AnimParameters
		{
			get => GetPropertyValue<CArray<entAnimTrackParameter>>();
			set => SetPropertyValue<CArray<entAnimTrackParameter>>(value);
		}

		[Ordinal(15)] 
		[RED("serverForcedLod")] 
		public CInt32 ServerForcedLod
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("clientForcedLod")] 
		public CInt32 ClientForcedLod
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("serverForcedVisibility")] 
		public CBool ServerForcedVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("clientForcedVisibility")] 
		public CBool ClientForcedVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entAnimatedComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			Animations = new animAnimSetup { Cinematics = new(), Gameplay = new() };
			AnimTags = new redTagList { Tags = new() };
			AnimParameters = new();
			ServerForcedLod = -1;
			ClientForcedLod = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
