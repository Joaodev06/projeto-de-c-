import { Text, SafeAreaView, StyleSheet,View } from 'react-native';

// You can import supported modules from npm


import Atividades from './ati/Atividades';
export default function App() {
  return (
 <View style={styles.view1}>
<Atividades/>
</View>
  
  );
}


const styles = StyleSheet.create({

view1:{
  backgroundColor:'red',
  justifyContent:'center',
  alignItems:'center',
  flex:1,
  padding:8,
},




});