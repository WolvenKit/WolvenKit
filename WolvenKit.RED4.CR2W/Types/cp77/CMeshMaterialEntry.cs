using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMeshMaterialEntry : CVariable
	{
		private CName _name;
		private CUInt16 _index;
		private CBool _isLocalInstance;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("index")] 
		public CUInt16 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CUInt16) CR2WTypeManager.Create("Uint16", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isLocalInstance")] 
		public CBool IsLocalInstance
		{
			get
			{
				if (_isLocalInstance == null)
				{
					_isLocalInstance = (CBool) CR2WTypeManager.Create("Bool", "isLocalInstance", cr2w, this);
				}
				return _isLocalInstance;
			}
			set
			{
				if (_isLocalInstance == value)
				{
					return;
				}
				_isLocalInstance = value;
				PropertySet(this);
			}
		}

		public CMeshMaterialEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
