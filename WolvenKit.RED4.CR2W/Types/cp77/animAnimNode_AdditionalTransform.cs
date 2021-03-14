using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AdditionalTransform : animAnimNode_OnePoseInput
	{
		private animAdditionalTransformContainer _additionalTransforms;

		[Ordinal(12)] 
		[RED("additionalTransforms")] 
		public animAdditionalTransformContainer AdditionalTransforms
		{
			get
			{
				if (_additionalTransforms == null)
				{
					_additionalTransforms = (animAdditionalTransformContainer) CR2WTypeManager.Create("animAdditionalTransformContainer", "additionalTransforms", cr2w, this);
				}
				return _additionalTransforms;
			}
			set
			{
				if (_additionalTransforms == value)
				{
					return;
				}
				_additionalTransforms = value;
				PropertySet(this);
			}
		}

		public animAnimNode_AdditionalTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
