using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnReferencePointDef : CVariable
	{
		private scnReferencePointId _id;
		private Vector3 _offset;
		private scnMarker _originMarker;

		[Ordinal(0)] 
		[RED("id")] 
		public scnReferencePointId Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(2)] 
		[RED("originMarker")] 
		public scnMarker OriginMarker
		{
			get => GetProperty(ref _originMarker);
			set => SetProperty(ref _originMarker, value);
		}

		public scnReferencePointDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
