using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IParticleDrawer : ISerializable
	{
		private CFloat _pivotOffset;

		[Ordinal(0)] 
		[RED("pivotOffset")] 
		public CFloat PivotOffset
		{
			get
			{
				if (_pivotOffset == null)
				{
					_pivotOffset = (CFloat) CR2WTypeManager.Create("Float", "pivotOffset", cr2w, this);
				}
				return _pivotOffset;
			}
			set
			{
				if (_pivotOffset == value)
				{
					return;
				}
				_pivotOffset = value;
				PropertySet(this);
			}
		}

		public IParticleDrawer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
