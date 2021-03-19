using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Rect : vgBaseVectorGraphicShape
	{
		private Vector2 _mensions;

		[Ordinal(2)] 
		[RED("mensions")] 
		public Vector2 Mensions
		{
			get => GetProperty(ref _mensions);
			set => SetProperty(ref _mensions, value);
		}

		public vgVectorGraphicShape_Rect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
