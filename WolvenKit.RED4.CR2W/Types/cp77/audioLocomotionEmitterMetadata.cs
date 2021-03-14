using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLocomotionEmitterMetadata : audioEmitterMetadata
	{
		private CName _customMaterialLookup;
		private CBool _isPlayer;

		[Ordinal(1)] 
		[RED("customMaterialLookup")] 
		public CName CustomMaterialLookup
		{
			get
			{
				if (_customMaterialLookup == null)
				{
					_customMaterialLookup = (CName) CR2WTypeManager.Create("CName", "customMaterialLookup", cr2w, this);
				}
				return _customMaterialLookup;
			}
			set
			{
				if (_customMaterialLookup == value)
				{
					return;
				}
				_customMaterialLookup = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		public audioLocomotionEmitterMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
