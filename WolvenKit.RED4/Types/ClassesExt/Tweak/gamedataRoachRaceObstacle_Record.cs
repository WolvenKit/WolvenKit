
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRoachRaceObstacle_Record
	{
		[RED("movement")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Movement
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("usingVelocityMultiplierRange")]
		[REDProperty(IsIgnored = true)]
		public CBool UsingVelocityMultiplierRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("velocity")]
		[REDProperty(IsIgnored = true)]
		public Vector2 Velocity
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("velocityMultiplierRange")]
		[REDProperty(IsIgnored = true)]
		public CArray<Vector2> VelocityMultiplierRange
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}
	}
}
