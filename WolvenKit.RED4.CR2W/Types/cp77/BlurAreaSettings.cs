using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlurAreaSettings : IAreaSettings
	{
		private CFloat _circularBlurRadius;

		[Ordinal(2)] 
		[RED("circularBlurRadius")] 
		public CFloat CircularBlurRadius
		{
			get
			{
				if (_circularBlurRadius == null)
				{
					_circularBlurRadius = (CFloat) CR2WTypeManager.Create("Float", "circularBlurRadius", cr2w, this);
				}
				return _circularBlurRadius;
			}
			set
			{
				if (_circularBlurRadius == value)
				{
					return;
				}
				_circularBlurRadius = value;
				PropertySet(this);
			}
		}

		public BlurAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
