using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPersistentSnapData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetObjectPath")] 
		public worldRelativeNodePath TargetObjectPath
		{
			get => GetPropertyValue<worldRelativeNodePath>();
			set => SetPropertyValue<worldRelativeNodePath>(value);
		}

		[Ordinal(1)] 
		[RED("targetSocketName")] 
		public CName TargetSocketName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("snapTangent")] 
		public CBool SnapTangent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("reverseTangent")] 
		public CBool ReverseTangent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("preserveLength")] 
		public CBool PreserveLength
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldPersistentSnapData()
		{
			TargetObjectPath = new() { Elements = new() };
			SnapTangent = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
