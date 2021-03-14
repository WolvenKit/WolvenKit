using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AmbientOverrideAreaSettings : IAreaSettings
	{
		private CArrayFixedSize<curveData<HDRColor>> _color;

		[Ordinal(2)] 
		[RED("color", 6)] 
		public CArrayFixedSize<curveData<HDRColor>> Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CArrayFixedSize<curveData<HDRColor>>) CR2WTypeManager.Create("[6]curveData:HDRColor", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		public AmbientOverrideAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
