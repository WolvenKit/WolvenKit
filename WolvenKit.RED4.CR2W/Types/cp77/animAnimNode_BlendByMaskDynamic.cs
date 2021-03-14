using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendByMaskDynamic : animAnimNode_Base
	{
		private animPoseLink _base;
		private animPoseLink _blend;
		private animIntLink _mask;
		private animFloatLink _weight;
		private CArray<CName> _masks;
		private CHandle<animISyncMethod> _syncMethod;

		[Ordinal(11)] 
		[RED("base")] 
		public animPoseLink Base
		{
			get
			{
				if (_base == null)
				{
					_base = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "base", cr2w, this);
				}
				return _base;
			}
			set
			{
				if (_base == value)
				{
					return;
				}
				_base = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("blend")] 
		public animPoseLink Blend
		{
			get
			{
				if (_blend == null)
				{
					_blend = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "blend", cr2w, this);
				}
				return _blend;
			}
			set
			{
				if (_blend == value)
				{
					return;
				}
				_blend = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("mask")] 
		public animIntLink Mask
		{
			get
			{
				if (_mask == null)
				{
					_mask = (animIntLink) CR2WTypeManager.Create("animIntLink", "mask", cr2w, this);
				}
				return _mask;
			}
			set
			{
				if (_mask == value)
				{
					return;
				}
				_mask = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weight", cr2w, this);
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

		[Ordinal(15)] 
		[RED("masks")] 
		public CArray<CName> Masks
		{
			get
			{
				if (_masks == null)
				{
					_masks = (CArray<CName>) CR2WTypeManager.Create("array:CName", "masks", cr2w, this);
				}
				return _masks;
			}
			set
			{
				if (_masks == value)
				{
					return;
				}
				_masks = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get
			{
				if (_syncMethod == null)
				{
					_syncMethod = (CHandle<animISyncMethod>) CR2WTypeManager.Create("handle:animISyncMethod", "syncMethod", cr2w, this);
				}
				return _syncMethod;
			}
			set
			{
				if (_syncMethod == value)
				{
					return;
				}
				_syncMethod = value;
				PropertySet(this);
			}
		}

		public animAnimNode_BlendByMaskDynamic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
