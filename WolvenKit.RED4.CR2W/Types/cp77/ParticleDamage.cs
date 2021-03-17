using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ParticleDamage : ISerializable
	{
		private CArray<Box> _boundingBoxes;

		[Ordinal(0)] 
		[RED("boundingBoxes")] 
		public CArray<Box> BoundingBoxes
		{
			get => GetProperty(ref _boundingBoxes);
			set => SetProperty(ref _boundingBoxes, value);
		}

		public ParticleDamage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
