using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPersistentSnapData : RedBaseClass
	{
		private worldRelativeNodePath _targetObjectPath;
		private CName _targetSocketName;
		private CBool _snapTangent;
		private CBool _reverseTangent;
		private CBool _preserveLength;

		[Ordinal(0)] 
		[RED("targetObjectPath")] 
		public worldRelativeNodePath TargetObjectPath
		{
			get => GetProperty(ref _targetObjectPath);
			set => SetProperty(ref _targetObjectPath, value);
		}

		[Ordinal(1)] 
		[RED("targetSocketName")] 
		public CName TargetSocketName
		{
			get => GetProperty(ref _targetSocketName);
			set => SetProperty(ref _targetSocketName, value);
		}

		[Ordinal(2)] 
		[RED("snapTangent")] 
		public CBool SnapTangent
		{
			get => GetProperty(ref _snapTangent);
			set => SetProperty(ref _snapTangent, value);
		}

		[Ordinal(3)] 
		[RED("reverseTangent")] 
		public CBool ReverseTangent
		{
			get => GetProperty(ref _reverseTangent);
			set => SetProperty(ref _reverseTangent, value);
		}

		[Ordinal(4)] 
		[RED("preserveLength")] 
		public CBool PreserveLength
		{
			get => GetProperty(ref _preserveLength);
			set => SetProperty(ref _preserveLength, value);
		}
	}
}
