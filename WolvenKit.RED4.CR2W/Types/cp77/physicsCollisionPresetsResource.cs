using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCollisionPresetsResource : ISerializable
	{
		private CArray<physicsCollisionPreset> _presets;

		[Ordinal(0)] 
		[RED("presets")] 
		public CArray<physicsCollisionPreset> Presets
		{
			get => GetProperty(ref _presets);
			set => SetProperty(ref _presets, value);
		}

		public physicsCollisionPresetsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
