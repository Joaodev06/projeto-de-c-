import React from'react'
import{View,Text,StyleSheet,TouchableOpacity} from 'react-native';
import { Ionicons } from '@expo/vector-icons';



export default function Index({data,deletar}){

return(
  <View style={styles.view1}>
  <Text>{data.item}</Text>
  <TouchableOpacity style={styles.icon} onPress={deletar}  >
  <Ionicons name="trash" size={24} color="black" />
  </TouchableOpacity>
  </View>
);


}

const styles = StyleSheet.create({
view1:{backgroundColor:'red',borderRadius:5,padding:15,flexDirection:'row',marginTop:10},
icon:{ }
})