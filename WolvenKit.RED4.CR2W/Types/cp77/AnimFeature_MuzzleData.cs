using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_MuzzleData : animAnimFeature
	{
		private Vector4 _muzzleOffset;

		[Ordinal(0)] 
		[RED("muzzleOffset")] 
		public Vector4 MuzzleOffset
		{
			get
			{
				if (_muzzleOffset == null)
				{
					_muzzleOffset = (Vector4) CR2WTypeManager.Create("Vector4", "muzzleOffset", cr2w, this);
				}
				return _muzzleOffset;
			}
			set
			{
				if (_muzzleOffset == value)
				{
					return;
				}
				_muzzleOffset = value;
				PropertySet(this);
			}
		}

		public AnimFeature_MuzzleData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
