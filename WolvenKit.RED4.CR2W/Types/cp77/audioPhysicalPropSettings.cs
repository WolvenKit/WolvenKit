using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalPropSettings : audioAudioMetadata
	{
		private CName _shockwaveSound;
		private CName _damagedSound;
		private CName _destroyedSound;
		private CArray<CName> _materialOverrides;

		[Ordinal(1)] 
		[RED("shockwaveSound")] 
		public CName ShockwaveSound
		{
			get
			{
				if (_shockwaveSound == null)
				{
					_shockwaveSound = (CName) CR2WTypeManager.Create("CName", "shockwaveSound", cr2w, this);
				}
				return _shockwaveSound;
			}
			set
			{
				if (_shockwaveSound == value)
				{
					return;
				}
				_shockwaveSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("damagedSound")] 
		public CName DamagedSound
		{
			get
			{
				if (_damagedSound == null)
				{
					_damagedSound = (CName) CR2WTypeManager.Create("CName", "damagedSound", cr2w, this);
				}
				return _damagedSound;
			}
			set
			{
				if (_damagedSound == value)
				{
					return;
				}
				_damagedSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("destroyedSound")] 
		public CName DestroyedSound
		{
			get
			{
				if (_destroyedSound == null)
				{
					_destroyedSound = (CName) CR2WTypeManager.Create("CName", "destroyedSound", cr2w, this);
				}
				return _destroyedSound;
			}
			set
			{
				if (_destroyedSound == value)
				{
					return;
				}
				_destroyedSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("materialOverrides")] 
		public CArray<CName> MaterialOverrides
		{
			get
			{
				if (_materialOverrides == null)
				{
					_materialOverrides = (CArray<CName>) CR2WTypeManager.Create("array:CName", "materialOverrides", cr2w, this);
				}
				return _materialOverrides;
			}
			set
			{
				if (_materialOverrides == value)
				{
					return;
				}
				_materialOverrides = value;
				PropertySet(this);
			}
		}

		public audioPhysicalPropSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
