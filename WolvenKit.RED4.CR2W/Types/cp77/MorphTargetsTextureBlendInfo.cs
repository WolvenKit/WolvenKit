using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MorphTargetsTextureBlendInfo : CVariable
	{
		private CBool _blend;
		private CEnum<MorphTargetsDiffTextureSize> _diffSize;
		private CName _name;

		[Ordinal(0)] 
		[RED("blend")] 
		public CBool Blend
		{
			get
			{
				if (_blend == null)
				{
					_blend = (CBool) CR2WTypeManager.Create("Bool", "blend", cr2w, this);
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

		[Ordinal(1)] 
		[RED("diffSize")] 
		public CEnum<MorphTargetsDiffTextureSize> DiffSize
		{
			get
			{
				if (_diffSize == null)
				{
					_diffSize = (CEnum<MorphTargetsDiffTextureSize>) CR2WTypeManager.Create("MorphTargetsDiffTextureSize", "diffSize", cr2w, this);
				}
				return _diffSize;
			}
			set
			{
				if (_diffSize == value)
				{
					return;
				}
				_diffSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		public MorphTargetsTextureBlendInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
