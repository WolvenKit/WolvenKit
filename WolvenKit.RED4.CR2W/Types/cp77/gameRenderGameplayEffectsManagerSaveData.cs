using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRenderGameplayEffectsManagerSaveData : ISerializable
	{
		private gameCyberspacePixelsortEffectParams _cyberspacePixelsortParams;
		private CBool _cyberspacePixelsortEnabled;
		private CBool _enforceScreenSpaceReflectionsUberQuality;

		[Ordinal(0)] 
		[RED("cyberspacePixelsortParams")] 
		public gameCyberspacePixelsortEffectParams CyberspacePixelsortParams
		{
			get
			{
				if (_cyberspacePixelsortParams == null)
				{
					_cyberspacePixelsortParams = (gameCyberspacePixelsortEffectParams) CR2WTypeManager.Create("gameCyberspacePixelsortEffectParams", "cyberspacePixelsortParams", cr2w, this);
				}
				return _cyberspacePixelsortParams;
			}
			set
			{
				if (_cyberspacePixelsortParams == value)
				{
					return;
				}
				_cyberspacePixelsortParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cyberspacePixelsortEnabled")] 
		public CBool CyberspacePixelsortEnabled
		{
			get
			{
				if (_cyberspacePixelsortEnabled == null)
				{
					_cyberspacePixelsortEnabled = (CBool) CR2WTypeManager.Create("Bool", "cyberspacePixelsortEnabled", cr2w, this);
				}
				return _cyberspacePixelsortEnabled;
			}
			set
			{
				if (_cyberspacePixelsortEnabled == value)
				{
					return;
				}
				_cyberspacePixelsortEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enforceScreenSpaceReflectionsUberQuality")] 
		public CBool EnforceScreenSpaceReflectionsUberQuality
		{
			get
			{
				if (_enforceScreenSpaceReflectionsUberQuality == null)
				{
					_enforceScreenSpaceReflectionsUberQuality = (CBool) CR2WTypeManager.Create("Bool", "enforceScreenSpaceReflectionsUberQuality", cr2w, this);
				}
				return _enforceScreenSpaceReflectionsUberQuality;
			}
			set
			{
				if (_enforceScreenSpaceReflectionsUberQuality == value)
				{
					return;
				}
				_enforceScreenSpaceReflectionsUberQuality = value;
				PropertySet(this);
			}
		}

		public gameRenderGameplayEffectsManagerSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
