using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPrefabVariantReplicatedInfo : CVariable
	{
		private CName _variantNameKey;
		private CBool _show;

		[Ordinal(0)] 
		[RED("variantNameKey")] 
		public CName VariantNameKey
		{
			get
			{
				if (_variantNameKey == null)
				{
					_variantNameKey = (CName) CR2WTypeManager.Create("CName", "variantNameKey", cr2w, this);
				}
				return _variantNameKey;
			}
			set
			{
				if (_variantNameKey == value)
				{
					return;
				}
				_variantNameKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get
			{
				if (_show == null)
				{
					_show = (CBool) CR2WTypeManager.Create("Bool", "show", cr2w, this);
				}
				return _show;
			}
			set
			{
				if (_show == value)
				{
					return;
				}
				_show = value;
				PropertySet(this);
			}
		}

		public questPrefabVariantReplicatedInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
