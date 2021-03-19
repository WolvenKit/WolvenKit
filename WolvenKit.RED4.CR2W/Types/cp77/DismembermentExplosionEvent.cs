using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentExplosionEvent : redEvent
	{
		private Vector4 _epicentrum;
		private CFloat _strength;

		[Ordinal(0)] 
		[RED("epicentrum")] 
		public Vector4 Epicentrum
		{
			get => GetProperty(ref _epicentrum);
			set => SetProperty(ref _epicentrum, value);
		}

		[Ordinal(1)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		public DismembermentExplosionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
