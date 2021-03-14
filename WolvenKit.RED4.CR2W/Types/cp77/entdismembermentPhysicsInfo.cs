using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentPhysicsInfo : CVariable
	{
		private CFloat _densityScale;

		[Ordinal(0)] 
		[RED("DensityScale")] 
		public CFloat DensityScale
		{
			get
			{
				if (_densityScale == null)
				{
					_densityScale = (CFloat) CR2WTypeManager.Create("Float", "DensityScale", cr2w, this);
				}
				return _densityScale;
			}
			set
			{
				if (_densityScale == value)
				{
					return;
				}
				_densityScale = value;
				PropertySet(this);
			}
		}

		public entdismembermentPhysicsInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
