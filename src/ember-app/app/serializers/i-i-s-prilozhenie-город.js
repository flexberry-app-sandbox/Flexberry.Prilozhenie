import { Serializer as ГородSerializer } from
  '../mixins/regenerated/serializers/i-i-s-prilozhenie-город';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(ГородSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
