using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterGradient : CMaterialParameter
	{
		private rRef<CGradient> _gradient;

		[Ordinal(2)] 
		[RED("gradient")] 
		public rRef<CGradient> Gradient
		{
			get
			{
				if (_gradient == null)
				{
					_gradient = (rRef<CGradient>) CR2WTypeManager.Create("rRef:CGradient", "gradient", cr2w, this);
				}
				return _gradient;
			}
			set
			{
				if (_gradient == value)
				{
					return;
				}
				_gradient = value;
				PropertySet(this);
			}
		}

		public CMaterialParameterGradient(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
