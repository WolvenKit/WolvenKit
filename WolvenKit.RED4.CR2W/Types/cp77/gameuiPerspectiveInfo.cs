using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPerspectiveInfo : CVariable
	{
		private CName _name;
		private CName _fpp;
		private CName _tpp;

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
		[RED("fpp")] 
		public CName Fpp
		{
			get
			{
				if (_fpp == null)
				{
					_fpp = (CName) CR2WTypeManager.Create("CName", "fpp", cr2w, this);
				}
				return _fpp;
			}
			set
			{
				if (_fpp == value)
				{
					return;
				}
				_fpp = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tpp")] 
		public CName Tpp
		{
			get
			{
				if (_tpp == null)
				{
					_tpp = (CName) CR2WTypeManager.Create("CName", "tpp", cr2w, this);
				}
				return _tpp;
			}
			set
			{
				if (_tpp == value)
				{
					return;
				}
				_tpp = value;
				PropertySet(this);
			}
		}

		public gameuiPerspectiveInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
