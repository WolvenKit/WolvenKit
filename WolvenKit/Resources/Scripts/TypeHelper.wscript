// @author Seberoth
// @version 1.0
import * as Logger from 'Logger.wscript';

class HashValue {
	constructor(value) {
		this.value = value;
	}
}

export class CName extends HashValue {
	constructor(value) {
		super(value)
	}
}

export class ResourcePath extends HashValue {
	constructor(value) {
		super(value)
	}
	
	isEmpty() {
		if (typeof(this.value) === 'string' && this.value !== '') {
			return false;
		}
		
		if (typeof(this.value) === 'bigint' && this.value !== BigInt("0")) {
			return false;
		}
		
		return true;
	}
	
	endsWith(value) {
		return typeof(this.value) === 'string' && this.value.endsWith(value);
	}
}

export class NodeRef extends HashValue {
	constructor(value) {
		super(value)
	}
}

export class TweakDBID extends HashValue {
	constructor(value) {
		super(value)
	}
}

function reviver(key, value) {
	if (value !== null && value.hasOwnProperty('$type')) {
		if (['CName', 'ResourcePath', 'TweakDBID', 'NodeRef'].includes(value['$type'])) {
			var propValue;
			switch(value['$storage']) {
				case 'string':
					propValue = value['$value'];
					break;
				case 'uint64':
					propValue = BigInt(value['$value']);
					break;
				default:
					throw new Error(`Unknown storage type "${value['$storage']}"`);
			}
			
			switch(value['$type']) {
				case 'CName':
					return new CName(propValue);
				case 'ResourcePath':
					return new ResourcePath(propValue);
				case 'NodeRef':
					return new NodeRef(propValue);
				case 'TweakDBID':
					return new TweakDBID(propValue);
				default:
					throw new Error(`Unknown value type "${value['$type']}"`);
			}
		}
	}

	return value;
}

export function JsonParse(value) {
	return JSON.parse(value, reviver);
}

function replacer(key, value) {
	if (value instanceof HashValue) {
		var dict = {};
		
		if (value instanceof CName) {
			dict['$type'] = 'CName';
		} else if (value instanceof ResourcePath) {
			dict['$type'] = 'ResourcePath';
		} else if (value instanceof NodeRef) {
			dict['$type'] = 'NodeRef';
		} else if (value instanceof TweakDBID) {
			dict['$type'] = 'TweakDBID';
		} else {
			throw new Error();
		}
		
		switch(typeof(value.value)) {
			case 'string':
				dict['$storage'] = 'string';
				dict['$value'] = value.value;
				break;
			case 'bigint':
				dict['$storage'] = 'uint64';
				dict['$value'] = value.value.toString();
				break;
			default:
				throw new Error(`Unknown value type "${typeof(value.value)}"`);
		}
		
		return dict;
	}
	return value;
}

export function JsonStringify(value, space) {
	return JSON.stringify(value, replacer, space);
}