using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSDOClickedRequest : gameScriptableSystemRequest
	{
		private CName _fullPath;
		private CName _key;

		[Ordinal(0)] 
		[RED("fullPath")] 
		public CName FullPath
		{
			get
			{
				if (_fullPath == null)
				{
					_fullPath = (CName) CR2WTypeManager.Create("CName", "fullPath", cr2w, this);
				}
				return _fullPath;
			}
			set
			{
				if (_fullPath == value)
				{
					return;
				}
				_fullPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get
			{
				if (_key == null)
				{
					_key = (CName) CR2WTypeManager.Create("CName", "key", cr2w, this);
				}
				return _key;
			}
			set
			{
				if (_key == value)
				{
					return;
				}
				_key = value;
				PropertySet(this);
			}
		}

		public gameSDOClickedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
