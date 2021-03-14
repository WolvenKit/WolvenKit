using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioEntityEmitterSettings : CVariable
	{
		private CName _emitterName;
		private CName _positionName;
		private CArray<CName> _emitterDecorators;
		private CBool _keepAlive;
		private CBool _isObjectPerPositionEmitter;

		[Ordinal(0)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get
			{
				if (_emitterName == null)
				{
					_emitterName = (CName) CR2WTypeManager.Create("CName", "emitterName", cr2w, this);
				}
				return _emitterName;
			}
			set
			{
				if (_emitterName == value)
				{
					return;
				}
				_emitterName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("positionName")] 
		public CName PositionName
		{
			get
			{
				if (_positionName == null)
				{
					_positionName = (CName) CR2WTypeManager.Create("CName", "positionName", cr2w, this);
				}
				return _positionName;
			}
			set
			{
				if (_positionName == value)
				{
					return;
				}
				_positionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("emitterDecorators")] 
		public CArray<CName> EmitterDecorators
		{
			get
			{
				if (_emitterDecorators == null)
				{
					_emitterDecorators = (CArray<CName>) CR2WTypeManager.Create("array:CName", "emitterDecorators", cr2w, this);
				}
				return _emitterDecorators;
			}
			set
			{
				if (_emitterDecorators == value)
				{
					return;
				}
				_emitterDecorators = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("keepAlive")] 
		public CBool KeepAlive
		{
			get
			{
				if (_keepAlive == null)
				{
					_keepAlive = (CBool) CR2WTypeManager.Create("Bool", "keepAlive", cr2w, this);
				}
				return _keepAlive;
			}
			set
			{
				if (_keepAlive == value)
				{
					return;
				}
				_keepAlive = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isObjectPerPositionEmitter")] 
		public CBool IsObjectPerPositionEmitter
		{
			get
			{
				if (_isObjectPerPositionEmitter == null)
				{
					_isObjectPerPositionEmitter = (CBool) CR2WTypeManager.Create("Bool", "isObjectPerPositionEmitter", cr2w, this);
				}
				return _isObjectPerPositionEmitter;
			}
			set
			{
				if (_isObjectPerPositionEmitter == value)
				{
					return;
				}
				_isObjectPerPositionEmitter = value;
				PropertySet(this);
			}
		}

		public audioEntityEmitterSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
