using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficCollisionDebug : ISerializable
	{
		private CArray<worldDbgOverlapBox> _overlapBoxes;

		[Ordinal(0)] 
		[RED("overlapBoxes")] 
		public CArray<worldDbgOverlapBox> OverlapBoxes
		{
			get => GetProperty(ref _overlapBoxes);
			set => SetProperty(ref _overlapBoxes, value);
		}

		public worldTrafficCollisionDebug(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
