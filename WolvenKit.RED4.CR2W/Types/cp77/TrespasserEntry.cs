using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrespasserEntry : CVariable
	{
		private wCHandle<gameObject> _trespasser;
		private CBool _isScanned;
		private CBool _isInsideA;
		private CBool _isInsideB;
		private CBool _isInsideScanner;
		private CArray<CName> _areaStack;

		[Ordinal(0)] 
		[RED("trespasser")] 
		public wCHandle<gameObject> Trespasser
		{
			get
			{
				if (_trespasser == null)
				{
					_trespasser = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "trespasser", cr2w, this);
				}
				return _trespasser;
			}
			set
			{
				if (_trespasser == value)
				{
					return;
				}
				_trespasser = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get
			{
				if (_isScanned == null)
				{
					_isScanned = (CBool) CR2WTypeManager.Create("Bool", "isScanned", cr2w, this);
				}
				return _isScanned;
			}
			set
			{
				if (_isScanned == value)
				{
					return;
				}
				_isScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isInsideA")] 
		public CBool IsInsideA
		{
			get
			{
				if (_isInsideA == null)
				{
					_isInsideA = (CBool) CR2WTypeManager.Create("Bool", "isInsideA", cr2w, this);
				}
				return _isInsideA;
			}
			set
			{
				if (_isInsideA == value)
				{
					return;
				}
				_isInsideA = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isInsideB")] 
		public CBool IsInsideB
		{
			get
			{
				if (_isInsideB == null)
				{
					_isInsideB = (CBool) CR2WTypeManager.Create("Bool", "isInsideB", cr2w, this);
				}
				return _isInsideB;
			}
			set
			{
				if (_isInsideB == value)
				{
					return;
				}
				_isInsideB = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isInsideScanner")] 
		public CBool IsInsideScanner
		{
			get
			{
				if (_isInsideScanner == null)
				{
					_isInsideScanner = (CBool) CR2WTypeManager.Create("Bool", "isInsideScanner", cr2w, this);
				}
				return _isInsideScanner;
			}
			set
			{
				if (_isInsideScanner == value)
				{
					return;
				}
				_isInsideScanner = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("areaStack")] 
		public CArray<CName> AreaStack
		{
			get
			{
				if (_areaStack == null)
				{
					_areaStack = (CArray<CName>) CR2WTypeManager.Create("array:CName", "areaStack", cr2w, this);
				}
				return _areaStack;
			}
			set
			{
				if (_areaStack == value)
				{
					return;
				}
				_areaStack = value;
				PropertySet(this);
			}
		}

		public TrespasserEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
