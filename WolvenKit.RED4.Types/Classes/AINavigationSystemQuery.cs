using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AINavigationSystemQuery : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("source")] 
		public AIPositionSpec Source
		{
			get => GetPropertyValue<AIPositionSpec>();
			set => SetPropertyValue<AIPositionSpec>(value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public AIPositionSpec Target
		{
			get => GetPropertyValue<AIPositionSpec>();
			set => SetPropertyValue<AIPositionSpec>(value);
		}

		[Ordinal(2)] 
		[RED("allowedTags")] 
		public CArray<CName> AllowedTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("blockedTags")] 
		public CArray<CName> BlockedTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("minDesiredDistance")] 
		public CFloat MinDesiredDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("maxDesiredDistance")] 
		public CFloat MaxDesiredDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("useFollowSlots")] 
		public CBool UseFollowSlots
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("usePredictionTime")] 
		public CBool UsePredictionTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AINavigationSystemQuery()
		{
			Source = new() { WorldPosition = new() { X = new(), Y = new(), Z = new() } };
			Target = new() { WorldPosition = new() { X = new(), Y = new(), Z = new() } };
			AllowedTags = new();
			BlockedTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
