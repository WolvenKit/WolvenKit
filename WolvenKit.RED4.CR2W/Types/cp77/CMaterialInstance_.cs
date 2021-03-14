using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialInstance_ : IMaterial
	{
		private rRef<IMaterial> _baseMaterial;
		private CBool _enableMask;
		private CName _audioTag;
		private CUInt8 _resourceVersion;

		[Ordinal(1)] 
		[RED("baseMaterial")] 
		public rRef<IMaterial> BaseMaterial
		{
			get
			{
				if (_baseMaterial == null)
				{
					_baseMaterial = (rRef<IMaterial>) CR2WTypeManager.Create("rRef:IMaterial", "baseMaterial", cr2w, this);
				}
				return _baseMaterial;
			}
			set
			{
				if (_baseMaterial == value)
				{
					return;
				}
				_baseMaterial = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enableMask")] 
		public CBool EnableMask
		{
			get
			{
				if (_enableMask == null)
				{
					_enableMask = (CBool) CR2WTypeManager.Create("Bool", "enableMask", cr2w, this);
				}
				return _enableMask;
			}
			set
			{
				if (_enableMask == value)
				{
					return;
				}
				_enableMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get
			{
				if (_audioTag == null)
				{
					_audioTag = (CName) CR2WTypeManager.Create("CName", "audioTag", cr2w, this);
				}
				return _audioTag;
			}
			set
			{
				if (_audioTag == value)
				{
					return;
				}
				_audioTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get
			{
				if (_resourceVersion == null)
				{
					_resourceVersion = (CUInt8) CR2WTypeManager.Create("Uint8", "resourceVersion", cr2w, this);
				}
				return _resourceVersion;
			}
			set
			{
				if (_resourceVersion == value)
				{
					return;
				}
				_resourceVersion = value;
				PropertySet(this);
			}
		}

		public CMaterialInstance_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
