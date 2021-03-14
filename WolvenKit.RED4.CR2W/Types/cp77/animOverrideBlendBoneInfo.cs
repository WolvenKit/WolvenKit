using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animOverrideBlendBoneInfo : CVariable
	{
		private animTransformIndex _transformIndex;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get
			{
				if (_transformIndex == null)
				{
					_transformIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "transformIndex", cr2w, this);
				}
				return _transformIndex;
			}
			set
			{
				if (_transformIndex == value)
				{
					return;
				}
				_transformIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		public animOverrideBlendBoneInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
