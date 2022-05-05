
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAttackDirection_Record
	{
		[RED("direction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Direction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("endPosition")]
		[REDProperty(IsIgnored = true)]
		public Vector3 EndPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("startPosition")]
		[REDProperty(IsIgnored = true)]
		public Vector3 StartPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
	}
}
