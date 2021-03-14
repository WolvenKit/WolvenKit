using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MaskReset : animAnimNode_OnePoseInput
	{
		private animFloatLink _weightNode;
		private CArray<animTransformIndex> _transforms;

		[Ordinal(12)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get
			{
				if (_weightNode == null)
				{
					_weightNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weightNode", cr2w, this);
				}
				return _weightNode;
			}
			set
			{
				if (_weightNode == value)
				{
					return;
				}
				_weightNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("transforms")] 
		public CArray<animTransformIndex> Transforms
		{
			get
			{
				if (_transforms == null)
				{
					_transforms = (CArray<animTransformIndex>) CR2WTypeManager.Create("array:animTransformIndex", "transforms", cr2w, this);
				}
				return _transforms;
			}
			set
			{
				if (_transforms == value)
				{
					return;
				}
				_transforms = value;
				PropertySet(this);
			}
		}

		public animAnimNode_MaskReset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
