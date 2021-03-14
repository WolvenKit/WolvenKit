using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ITonemappingMode : ISerializable
	{
		private curveData<CFloat> _colorPreservation;

		[Ordinal(0)] 
		[RED("colorPreservation")] 
		public curveData<CFloat> ColorPreservation
		{
			get
			{
				if (_colorPreservation == null)
				{
					_colorPreservation = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "colorPreservation", cr2w, this);
				}
				return _colorPreservation;
			}
			set
			{
				if (_colorPreservation == value)
				{
					return;
				}
				_colorPreservation = value;
				PropertySet(this);
			}
		}

		public ITonemappingMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
