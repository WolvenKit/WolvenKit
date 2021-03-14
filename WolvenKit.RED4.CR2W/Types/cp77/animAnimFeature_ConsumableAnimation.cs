using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_ConsumableAnimation : animAnimFeature
	{
		private CInt32 _consumableType;
		private CBool _useConsumable;

		[Ordinal(0)] 
		[RED("consumableType")] 
		public CInt32 ConsumableType
		{
			get
			{
				if (_consumableType == null)
				{
					_consumableType = (CInt32) CR2WTypeManager.Create("Int32", "consumableType", cr2w, this);
				}
				return _consumableType;
			}
			set
			{
				if (_consumableType == value)
				{
					return;
				}
				_consumableType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useConsumable")] 
		public CBool UseConsumable
		{
			get
			{
				if (_useConsumable == null)
				{
					_useConsumable = (CBool) CR2WTypeManager.Create("Bool", "useConsumable", cr2w, this);
				}
				return _useConsumable;
			}
			set
			{
				if (_useConsumable == value)
				{
					return;
				}
				_useConsumable = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_ConsumableAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
