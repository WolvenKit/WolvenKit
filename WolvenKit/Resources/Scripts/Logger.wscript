// @version 1.0
// Logger.wscript

function ConvertObject(obj) {
    if (null === obj) { // typeof null will be object -.- 
        return "null";
    }
    if (undefined === obj) {
        return "undefined";
    }
     if (typeof obj === "string") {
        return obj;
    } else if (typeof obj === "object") {
       return JSON.stringify(obj, null, 4);
   } else {
        return obj.ToString();
    }
}

export function Info(obj) {
    logger.Info(ConvertObject(obj));
}

export function Warning(obj) {
    logger.Warning(ConvertObject(obj));
}

export function Error(obj) {
    logger.Error(ConvertObject(obj));
}

export function Success(obj) {
    logger.Success(ConvertObject(obj));
}

export function Debug(obj) {
    logger.Debug(ConvertObject(obj));
}