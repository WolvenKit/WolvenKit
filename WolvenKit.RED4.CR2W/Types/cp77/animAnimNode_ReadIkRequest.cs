using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ReadIkRequest : animAnimNode_OnePoseInput
	{
		private CName _ikChain;
		private animTransformIndex _outTransform;

		[Ordinal(12)] 
		[RED("ikChain")] 
		public CName IkChain
		{
			get
			{
				if (_ikChain == null)
				{
					_ikChain = (CName) CR2WTypeManager.Create("CName", "ikChain", cr2w, this);
				}
				return _ikChain;
			}
			set
			{
				if (_ikChain == value)
				{
					return;
				}
				_ikChain = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("outTransform")] 
		public animTransformIndex OutTransform
		{
			get
			{
				if (_outTransform == null)
				{
					_outTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "outTransform", cr2w, this);
				}
				return _outTransform;
			}
			set
			{
				if (_outTransform == value)
				{
					return;
				}
				_outTransform = value;
				PropertySet(this);
			}
		}

		public animAnimNode_ReadIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
