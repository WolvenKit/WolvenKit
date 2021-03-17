using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformSyncMatrixRequest : gameReplAnimTransformRequestBase
	{
		private Transform _transform;

		[Ordinal(1)] 
		[RED("transform")] 
		public Transform Transform
		{
			get => GetProperty(ref _transform);
			set => SetProperty(ref _transform, value);
		}

		public gameReplAnimTransformSyncMatrixRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
