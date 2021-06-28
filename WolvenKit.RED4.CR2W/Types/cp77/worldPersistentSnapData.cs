using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPersistentSnapData : CVariable
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

		public worldPersistentSnapData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
